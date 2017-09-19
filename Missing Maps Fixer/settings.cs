using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missing_Maps_Fixer
{


    public partial class settings : Form
    {
        private MainForm _main;
        private Properties.Settings config = Properties.Settings.Default;
      

        public settings(MainForm main, settings se)
        {
            InitializeComponent();

            _main = main;
        }


        private void settings_Load(object sender, EventArgs e)
        {
            _main.buttonFix.Enabled = false;
            _main.buttonUpdates.Enabled = false;
            _main.buttonSettings.Enabled = false;

            config.steamPath = Properties.Settings.Default.steamPath;

            labelPath.Text = config.steamPath;
            
            if ((labelPath.Size.Width + 84) > 139)
            {
                buttonChange.Location = new System.Drawing.Point((labelPath.Size.Width + 10), buttonChange.Location.Y);
                gBoxSteamPath.Size = new Size(new Point(labelPath.Size.Width + 84, gBoxSteamPath.Size.Height));
            }

            if (!(Directory.Exists(config.steamPath)))
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = ("Status: Failed to find : \"" + config.steamPath + "\"");
            }

            else

            {

                Dictionary<string, string> games = new Dictionary<string, string>();
                games.Add("Team Fortress 2", "labelTF2");
                games.Add("GarrysMod", "labelGmod");
                games.Add("Counter-Strike Global Offensive", "labelCSGO");

                string labelName;
                int found = 0;

                foreach (string game in games.Keys)
                {

                    labelName = games[game];

                    var gameLabels = Controls.Find(labelName, true);
                    var gameLabel = (Label)gameLabels[0];

                    if (gameCheck(game))
                    {
                        found = found + 1;

                        gameLabel.Text = game + " - Found";
                        gameLabel.ForeColor = Color.Green;
                    }

                    else

                    {
                        gameLabel.Text = game + " - Not Found";
                        gameLabel.ForeColor = Color.Red;
                    } 
                }

                if (found > 0)
                {
                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = ("Status: Found: \"" + config.steamPath + "\" and compatible games.");
                }
               
                else

                {
                    labelStatus.ForeColor = Color.Orange;
                    labelStatus.Text = ("Status: Could not find any compatible games in \"" + config.steamPath + "\"");
                }
            }

            if ((labelStatus.Size.Width + 40) > 260)
            {
                this.Size = new Size(new Point(labelStatus.Size.Width + 40, this.Size.Height));
            }
        }


        public Boolean mainCheck()
        {
            Dictionary<string, string> games = new Dictionary<string, string>();
            games.Add("Team Fortress 2", "labelTF2");
            games.Add("GarrysMod", "labelGmod");
            games.Add("Counter-Strike Global Offensive", "labelCSGO");

            int found = 0;

            foreach (string game in games.Keys)
            {

                if (gameCheck(game))
                {
                    found = found + 1;
                }

            }

            if (found > 0)
            {
                return true;
            }

            else

            {
                return false;
            }
        }


        public Boolean gameCheck(string game)
        {

            if (Directory.Exists(config.steamPath + "\\" + game))
            {
                return true;
            }

            else

            {
                return false;
            }
        }


        private void buttonChange_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            config.steamPath = folderDialog.SelectedPath;

            settings_Load(this, EventArgs.Empty);
            config.Save();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            _main.buttonFix.Enabled = true;
            _main.buttonUpdates.Enabled = true;
            _main.buttonSettings.Enabled = true;

            this.Hide();
        }
    }
}
