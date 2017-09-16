using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.ComponentModel;
using System.Windows.Forms;

namespace Missing_Maps_Fixer
{


    public class fileDownload
    {
        private WebClient client = new WebClient();
        private static BackgroundWorker backWorkerMap = new BackgroundWorker();
        private static BackgroundWorker backWorkerTimer = new BackgroundWorker();

        private static Boolean done;
        private static Boolean updateNeeded;
        private static fileExtract _fExtract;
        private static MainForm _main;
        private static long oldRecieved;
        private static long currentRecieved;
        private static long totalRecieved;
        private static string timeRemaining;
        public static string mapName;

        private string[] hostList = {"http://files.gamebanana.com/maps/",
            "http://fastdl.gflclan.com/garrysmod/maps/",
            "http://fastdl.gflclan.com/csgo/maps/",
            "http://dl.openfastdl.net/tf/maps/",
            "http://fakkelbrigade.eu/maps/",
            "http://ouroborosgaming.net/garrysmod/maps/"};

        public fileDownload(MainForm main, fileExtract fe)
        {
            _main = main;
            _fExtract = fe;
        }


        public void map(string missingMap)
        {
            backWorkerMap.DoWork += new DoWorkEventHandler(backWorkerMap_DoWork);
            backWorkerTimer.DoWork += new DoWorkEventHandler(backWorkerTimer_DoWork);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_ProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(download_Completed);

            _main.labelInfo_Change("Preparing to find server...");

            mapName = missingMap;

            timeRemaining = "Calculating...";
            
            backWorkerMap.WorkerSupportsCancellation = true;
            backWorkerTimer.WorkerSupportsCancellation = true;

            done = false;

            backWorkerMap.RunWorkerAsync();
            backWorkerTimer.RunWorkerAsync();

        }


        private void backWorkerMap_DoWork(object sender, DoWorkEventArgs e)
        {
            _main.labelInfo_Change("Finding server...");

            foreach (string host in hostList)
            {
                System.Threading.Thread.Sleep(800);

                if (client.IsBusy == false && _main.labelInfo.Text == "Finding server...")
                {
                    
                    try
                    {
                        client.DownloadFileAsync(new System.Uri(host + mapName + ".bsp"), "C:\\Users\\Public\\Documents\\" + mapName + ".bsp");
                    }

                    catch (Exception exception)

                    {
                        MessageBox.Show(exception.Message);
                    }
                }

                else

                {
                   break;
                }
            }  
        }


        private void download_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _main.labelInfo_Change("Downloading map \"" + mapName + "\" - " + e.ProgressPercentage.ToString() + "% " + timeRemaining);
            _main.pBarMain_Change(e.ProgressPercentage);
           
            currentRecieved = e.BytesReceived;
                totalRecieved = e.TotalBytesToReceive;
           
        }


        private void backWorkerTimer_DoWork(object sender, DoWorkEventArgs e)
        {

            long differenceRecieved;
            long currentRemaining;
            double secondsRemaining;

            while (done == false)
            {
                if (_main.labelInfo.Text.Contains("Downloading"))
                {
                    oldRecieved = currentRecieved;

                    System.Threading.Thread.Sleep(1000);

                    differenceRecieved = currentRecieved - oldRecieved;
                    currentRemaining = totalRecieved - currentRecieved;
                    secondsRemaining = currentRemaining / differenceRecieved;

                    TimeSpan time = TimeSpan.FromSeconds(secondsRemaining);
                    timeRemaining = string.Format("{0:D2}m:{1:D2}s remaining...",
                        time.Minutes,
                        time.Seconds);
                }

            }

        }
            
    
        private void download_Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {

                if (backWorkerMap.IsBusy == false && e.Error.Message != null)
                {
                    _main.labelInfo_Change("Unable to find map!");
                    _main.finished(false);
                    done = true;
                }
            }

            catch (Exception exception)

            {
                done = true;
                backWorkerMap.CancelAsync();

                _fExtract = new fileExtract(_main, this);
                _fExtract.map(mapName);
            }
        }     
    }
}
