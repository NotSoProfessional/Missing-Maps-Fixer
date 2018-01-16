using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
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
        private static fileExtract _fExtract;
        private static MainForm _main;
        private static long oldRecieved;
        private static long currentRecieved;
        private static long totalRecieved;
        private static string timeRemaining;
        private static string fileType;
        public static string mapName;

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

            var hostDict = new Dictionary<string, string[]>();
            hostDict.Add("http://files.gamebanana.com/maps/", new string[] { ".rar", ".zip", ".7z"});
            hostDict.Add("https://files.gamebanana.com/maps/", new string[] { ".zip"});
            hostDict.Add("http://fastdl.gflclan.com/garrysmod/maps/", new string[] { ".bsp.bz2" });
            hostDict.Add("http://fastdl.gflclan.com/csgo/maps/", new string[] { ".bsp.bz2" });
            hostDict.Add("http://dl.openfastdl.net/tf/maps/", new string[] { ".bsp.bz2" });
            hostDict.Add("http://fakkelbrigade.eu/maps/", new string[] { ".bsp.bz2" });
            hostDict.Add("http://ouroborosgaming.net/garrysmod/maps/", new string[] { ".bsp.bz2" });

            foreach (string host in hostDict.Keys)
            {
                string[] types;
                types = hostDict[host];
                System.Threading.Thread.Sleep(1100);
                if (client.IsBusy == false && _main.labelInfo.Text == "Finding server...")
                  { 
                foreach (string type in types)
                    {

                        if (client.IsBusy == false && _main.labelInfo.Text == "Finding server...")
                        {

                            try
                            {
                                client.DownloadFileAsync(new System.Uri(host + mapName + type), Path.GetTempPath() + mapName + type);

                                fileType = type;
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
                    try
                    {
                        secondsRemaining = currentRemaining / differenceRecieved;
                        TimeSpan time = TimeSpan.FromSeconds(secondsRemaining);
                        timeRemaining = string.Format("{0:D2}m:{1:D2}s remaining...",
                            time.Minutes,
                            time.Seconds);
                    }

                    catch (Exception exception)

                    {
                        
                    }
                }
            }
        }
            
    
        private void download_Completed(object sender, AsyncCompletedEventArgs e)
        {

            try
            {

                if (backWorkerMap.IsBusy == false && e.Error.Message != null)
                {
                    done = true;
                    _main.labelInfo_Change("Unable to find map!");
                    _main.finished(false);
                }
            }

            catch (Exception exception)

            {
                done = true;

                _main.pBarMain_Change(100);

                backWorkerMap.CancelAsync();

                _fExtract = new fileExtract(_main, this);
                _fExtract.map(mapName, fileType);
            }
        }     
    }
}
