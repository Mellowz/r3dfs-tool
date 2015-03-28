using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using zlib;
using System.IO.Compression;

namespace BIN_Editor.r3d
{
    public unsafe class FileSystem
    {
        private Folder _root = new Folder("ROOT");

        private int _version = 0;
        private int _filecount = 0;
        private string _basePath = "";
		private string _prefix = "";
        private CRC32 _crc = new CRC32();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="BasePath"></param>
		public FileSystem(string BasePath, string Prefix)
        {
            _basePath = BasePath;
			_prefix = Prefix;

            #region Read Index-File

            // Open Index-File

            string fName = _prefix + "_00.bin";

            FileStream fstream = new FileStream(Path.Combine(BasePath, fName), FileMode.Open);
            BinaryReader reader = new BinaryReader(fstream);

            //CPU Disasm
            //Address   Hex dump          Command                                               Comments

            //01358803  |.  8BBC24 BC0000 MOV EDI,DWORD PTR SS:[ARG.1]
            //0135880A  |.  8B07          MOV EAX,DWORD PTR DS:[EDI]
            int magic = reader.ReadInt32();

            //0135880C  |.  8B4F 04       MOV ECX,DWORD PTR DS:[EDI+4]
            _version = reader.ReadInt32();

            //0135880F  |.  C78424 B40000 MOV DWORD PTR SS:[LOCAL.0],0

            //0135881A  |.  3D 6172666C   CMP EAX,6C667261                                      ; > Check Magic
            //0135881F  |.  74 3A         JE SHORT valid_File
            if (magic != 0x6C667261) // (string)arfl
            {
                //01358821  |.  8B8424 C40000 MOV EAX,DWORD PTR SS:[ARG.3]
                //01358828  |.  50            PUSH EAX
                //01358829  |.  68 F4984301   PUSH OFFSET 014398F4                                  ; ASCII "r3dFS: file list file %s is corrupt"
                //0135882E  |>  E8 DD0BFFFF   CALL LogThis

                throw new Exception("r3dFS: file list file " + fName + " is corrupt");
            }

            // Debug
            Console.WriteLine("Magic {0:x}", magic);

            

            //0135885B  |> \83F9 01       CMP ECX,1                                             ; > Version Check
            //0135885E  |.  74 3B         JE SHORT valid_Version
            if (_version != 1)
            {
                //01358860  |.  51            PUSH ECX
                //01358861  |.  8B8C24 C80000 MOV ECX,DWORD PTR SS:[ARG.3]
                //01358868  |.  51            PUSH ECX
                //01358869  |.  68 BC984301   PUSH OFFSET 014398BC                                  ; ASCII "r3dFS: file list file %s have unsupported version %d"
                //0135886E  |.  E8 9D0BFFFF   CALL LogThis

                throw new Exception("r3dFS: file list file " + fName + " have unsupported version " + _version.ToString());
            }

            // Debug
            Console.WriteLine("Version: {0:x}", _version);

            int dw2 = reader.ReadInt32();
            Console.WriteLine("dw2: {0:x}", dw2);

            int numFiles = reader.ReadInt32();
            Console.WriteLine("Number of Files: {0}", numFiles.ToString());

            _filecount = numFiles;

            //0135889B  |> \83BC24 C00000 CMP DWORD PTR SS:[ARG.2],18                           ; > Check for FileSize ... ?!?
            //013588A3  |.  73 12         JNB SHORT 013588B7
            if (fstream.Length < 18)
            {
                //013588A5  |.  8B9424 C40000 MOV EDX,DWORD PTR SS:[ARG.3]
                //013588AC  |.  52            PUSH EDX
                //013588AD  |.  68 9C984301   PUSH OFFSET 0143989C                                  ; ASCII "r3dFS: file list file %s EOF#1"
                //013588B2  |.^ E9 77FFFFFF   JMP _logThis-above                                    ; Compiler - You just saved 1 Byte, congrats

                throw new Exception("File List File is EOF#1");
            }
            
            // Copy Stream into ByteArray
            fstream.Position = 24;

            ZInputStream zs = new ZInputStream(fstream);

            for (int i = 1; i <= numFiles - 1; i++)
            {

                byte[] buf = new byte[0x128];
                
                // Read from Stream until 0x128 Bytes are read
                int count = 0;
                do
                {
                    // Recalculate remaining bytes to read
                    count += zs.read(buf, count, 0x128 - count);

                    // Output some Debug-Stuff
                    if (count < 0x128)
                    {
                        Console.WriteLine("Not enough Bytes read | Count: {0} BytesRead: {1}", i, count);
                    }

                } while (count < 0x128);

                // Cast Byte-Array into FileEntry-struct
                FileEntry f = (FileEntry)ByteArrayToStruct(buf, 0, typeof(FileEntry));

                // Create File/Folder-Structure
                string[] path = f.filePath.Split(new char[] { '\\' });

                Folder currentFolder = _root;

                for (int u = 0; u < path.Length - 1; u++)
                {
                    currentFolder = currentFolder.CreateFolder(path[u]);
                }

                currentFolder.AddFile(new File(f));

                //int start = 5000;
                //if (i > start && i < start + 20)
                //{
                    
                //    Console.Write("0x{0:x} 0x{1:x} ", f.unk2, f.unk3);

                //    foreach (byte bt in f.unk4)
                //    {
                //        Console.Write("0x{0:x} ", bt);
                //    }

                //    Console.WriteLine();

                    
                //}
            }

            #endregion

        }

        public Folder GetFolderFromPath(string path)
        {
            string[] spath = path.Split(new char[] { '\\' });

            // Walk through simulated directory structure ...
            Folder currentFolder = _root;

            // Start at 1 to skip ROOT-Folder
            for (int i = 1; i < spath.Length; i++)
            {
                currentFolder = currentFolder[spath[i]];
            }

            return currentFolder;
        }

        public void ExtractFile(File file)
        {
            Console.Write("Extracting File: {0} {1}B {2} ", file.FullPath, file.CompressedSize, file.StoreInfo.ToString());
            // Add 4 Byte to Size for magic
            int size = file.CompressedSize;
            int volumeId = file.VolumeIndex + 1;

            #region Open File
            // Open Volume
            FileStream fs = new FileStream(Path.Combine(_basePath, _prefix + "_0" + volumeId.ToString() + ".bin"), FileMode.Open);

            // Create OutFile
			Directory.CreateDirectory("out" + Path.DirectorySeparatorChar + file.Path.Replace('\\', Path.DirectorySeparatorChar ));
			FileStream outfs = new FileStream("out" + Path.DirectorySeparatorChar + file.FullPath.Replace('\\', Path.DirectorySeparatorChar ), FileMode.Create);
            

            // Move FilePointer along
            if (fs.CanSeek)
            {
                fs.Position = file.Offset;
            }
            else
            {
                throw new Exception("FileStream not seek-able");
            }

            // Check if Position is right
            byte[] magic = new byte[4];

            ReadExact(ref fs, ref magic, 4);

            // Check the Magic
            if (!(magic[0] == 0x61 &&
                magic[1] == 0x72 &&
                magic[2] == 0x66 &&
                magic[3] == 0x64))
            {
                throw new Exception("Could not extract: Wrong Offset does not match a valid file (magic)");
            }
            #endregion

            // Calculate some sizes
            int bytesLeft = size;

            int bufsize = 512;
            byte[] buffer = new byte[bufsize];

            try
            {
                if (file.StoreInfo == StoreInfo.COMPRESSED)
                {
                    //Setup ZLib-Stream
                    ZOutputStream zs = new ZOutputStream(outfs);

                    CopyStream(fs, zs, size);

                    zs.Close();
                }
                else
                {
                    CopyStream(fs, outfs, size);
                }

                int CRC = (int)_crc.GetCRC32FromFile("out/" + file.FullPath);

                if (CRC == file.CRC32)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CRC-OK");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("CRC-FAIL");
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("\r\n");

                //Console.WriteLine("CRC {0:x} {1:x}", (uint)CRC, file.CRC32);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("failed");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            finally
            {
                // Close Outfile
                outfs.Close();

                // Close Volume
                fs.Close();
            }

        }

        #region Properties

        public Folder Root
        {
            get
            {
                return _root;
            }
        }

        public int Version
        {
            get { return _version; }
        }

        public int FileCount
        {
            get { return _filecount; }
        }
        #endregion

        #region ByteArrayToStruct
        // Source: http://dotnet-snippets.de/dns/byte-array-in-struktur-kopieren-SID1500.aspx
        // Thank you :)
        /// <summary>
        /// Kopiert Daten aus einem Byte-Array in eine entsprechende Strukture (struct). Die Struktur muss ein sequenzeilles Layout besitzen. ( [StructLayout(LayoutKind.Sequential)] 
        /// </summary>
        /// <param name="array">Das Byte-Array das die daten enthält</param>
        /// <param name="offset">Offset ab dem die Daten in die Struktur kopiert werden sollen.</param>
        /// <param name="structType">System.Type der Struktur</param>
        /// <returns></returns>
        static object ByteArrayToStruct(byte[] array, int offset, Type structType)
        {
            if (structType.StructLayoutAttribute.Value != LayoutKind.Sequential)
                throw new ArgumentException("structType ist keine Struktur oder nicht Sequentiell.");

            int size = Marshal.SizeOf(structType);
            if (array.Length < (offset + size))
                throw new ArgumentException("Byte-Array hat die falsche Länge.");

            byte[] tmp = new byte[size];
            Array.Copy(array, offset, tmp, 0, size);

            GCHandle structHandle = GCHandle.Alloc(tmp, GCHandleType.Pinned);
            object structure = Marshal.PtrToStructure(structHandle.AddrOfPinnedObject(), structType);
            structHandle.Free();

            return structure;
        }
        #endregion

        #region ReadExact

        /// <summary>
        /// Function that reads the given bytecount, safely!
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="buffer"></param>
        /// <param name="count"></param>
        private void ReadExact(ref FileStream stream, ref byte[] buffer, int count)
        {
            // Read from Stream until 0x128 Bytes are read
            int _count = 0;
            do
            {
                // Recalculate remaining bytes to read
                _count += stream.Read(buffer, _count, count - _count);

                // Output some Debug-Stuff
                if (_count < count)
                {
                    Console.WriteLine("Not enough Bytes read | BytesRead: {0}", _count);
                }

            } while (_count < count);


        }

        #endregion

        /// <summary>
        /// Copies the given amount of bytes from one stream to another
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="count"></param>
        private void CopyStream(Stream from, Stream to, int count)
        {
            int bytesLeft = count;

            int bufsize = 512;
            byte[] buffer = new byte[bufsize];

            while (bytesLeft > 0)
            {
                // If size is smaller than buffersize, dont read more bytes than required to prevent bytesLeft from gettin negative
                // Also fixes the bug, that the Outfile will have more bytes than the original size had
                if (bytesLeft < bufsize)
                    bufsize = bytesLeft;

                int bytesRead = from.Read(buffer, 0, bufsize);
                bytesLeft = bytesLeft - bytesRead;

                to.Write(buffer, 0, bytesRead);
                to.Flush();
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FileEntry
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string filePath;
        public byte storeInfo;
        public byte volumeIndex;
        public int offset;
        public int realsize;
        public int csize;
        public int crc32;
        public int unk2;
        public int unk3;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
        public byte[] unk4;
    }

    public enum StoreInfo
    {
        UNKNOWN = 0,
        NOT_COMPRESSED = 1,
        COMPRESSED = 2
    }
}
