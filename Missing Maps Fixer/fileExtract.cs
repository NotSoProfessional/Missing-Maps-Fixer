using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        public void map(string mapName)
        { 
            _main.finished(true);
        }
    }
}
