using System;

namespace BIN_Editor.r3d
{
	public class File
	{
		FileEntry innerFileEntry;

		string fileName;
		StoreInfo storeInfo;
		string path;
		string fullPath;

		public File (FileEntry file)
		{
			innerFileEntry = file;
			
			// Since the path comes with microsoft-style separators, this will break
			// any non-microsoft operating system
			// Better replace them with the correct separator for the current OS
			fullPath = file.filePath.Replace ('\\', System.IO.Path.DirectorySeparatorChar);
			
			
			path = System.IO.Path.GetDirectoryName (fullPath);
			fileName = System.IO.Path.GetFileName (fullPath);
			
			switch (file.storeInfo)
			{
				case 1:
					storeInfo = StoreInfo.NOT_COMPRESSED;
					break;
				case 2:
					storeInfo = StoreInfo.COMPRESSED;
					break;

				default:
					storeInfo = StoreInfo.UNKNOWN;
					break;
			}
		}

		public string Name
		{
			get { return fileName; }
		}

		public string Path
		{
			get { return path; }
		}

		public string OriginalPath
		{
			get { return innerFileEntry.filePath; }
		}

		public int CRC32
		{
			get { return innerFileEntry.crc32; }
		}

		public int RealSize
		{
			get { return innerFileEntry.realsize; }
		}

		public int CompressedSize
		{
			get { return innerFileEntry.csize; }
		}

		public int Offset
		{
			get { return innerFileEntry.offset; }
		}

		public byte VolumeIndex
		{
			get { return innerFileEntry.volumeIndex; }
		}

		public StoreInfo StoreInfo
		{
			get { return storeInfo; }
		}

	}
}
