using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using SharpCompress.Common;
using SharpCompress.Reader;

namespace Missing_Maps_Fixer
{


    public class fileExtract
    {
        private static MainForm _main;
        private static fileDownload _fDownload;

        public fileExtract(MainForm main, fileDownload fd)
        {
            _main = main;
            _fDownload = fd;
            
        }

        public void map(string mapName, string type)
        {

            using (Stream stream = File.OpenRead(Path.GetTempPath() + mapName + type))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        reader.WriteEntryToDirectory(Path.GetTempPath() + mapName, ExtractOptions.Overwrite | ExtractOptions.ExtractFullPath);
                    }
                }
            }
            
            _main.finished(true);
          
        }
    }
}
