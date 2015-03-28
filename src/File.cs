using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIN_Editor.r3d
{
    public class File
    {
        FileEntry _file;

        string _filename;
        StoreInfo _storeInfo;


        string _path = "";
        string[] _pathar;

        public File(FileEntry file)
        {
            _file = file;
            _pathar = file.filePath.Split(new char[] { '\\'});

            for (int i = 0; i < _pathar.Length - 1; i++)
            {
                _path += _pathar[i] + "/";
            }

            _filename = _pathar[_pathar.Length - 1];

            switch (file.storeInfo)
            {
                case 1:
                    _storeInfo = StoreInfo.NOT_COMPRESSED;
                    break;
                case 2:
                    _storeInfo = StoreInfo.COMPRESSED;
                    break;

                default:
                    _storeInfo = StoreInfo.UNKNOWN;
                    break;
            }

        }

        public string Name
        {
            get { return _filename; }
        }

        public string Path
        {
            get { return _path; }
        }

        public string FullPath
        {
            get { return _file.filePath; }
        }

        public string[] PathArray
        {
            get { return _pathar; }
        }

        public int CRC32
        {
            get { return _file.crc32; }
        }

        public int RealSize
        {
            get { return _file.realsize; }
        }

        public int CompressedSize
        {
            get { return _file.csize; }
        }

        public int Offset
        {
            get { return _file.offset; }
        }

        public byte VolumeIndex
        {
            get { return _file.volumeIndex; }
        }

        public StoreInfo StoreInfo
        {
            get { return _storeInfo; }
        }

    }
}
