using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missing_Maps_Fixer
{


    public partial class MainForm : Form
    {

        private fileDownload fd;
        private fileExtract fe;
        private settings se;

        public MainForm()
        {
            InitializeComponent();

            this.Shown += new EventHandler(main_Shown);
        }


        private void main_Load(object sender, EventArgs e)
        {
            this.CreateControl();
            linkLabelAuthor.Links.Add(0, 100, "www.youtube.com/notsoprofessional");

            cboxGameSelect.SelectedIndex = 0;
        }


        private void main_Shown(object sender, EventArgs e)
        {

            if (!(Directory.Exists(Properties.Settings.Default.steamPath)))
            {
                notFound("Could not find Steam path! Are your games installed somewhere else?");
            }

            else

            {
                se = new settings(this, se);
                if (!(se.mainCheck()))
                {
                    notFound("Could not find any compatible games in your Steam path! Change it to where your games are located!");
                }
            }
        }


        private void notFound(string error)
        {
            se = new settings(this, se);
            se.Show();
            se.TopMost = true;

            MessageBox.Show(error);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }


        private void buttonFix_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(tBoxMap.Text, "[a-zA-Z]")))
            {
                labelInfo_Change("Please enter a map!");
            }

            else

            {

                if (se.gameCheck(cboxGameSelect.Text))
                {
                    fd = new fileDownload(this, fe);
                    fd.map(tBoxMap.Text);

                    pBarMain.Value = 0;
                    buttonFix.Enabled = false;
                    buttonSettings.Enabled = false;
                    buttonUpdates.Enabled = false;
                    cboxGameSelect.Enabled = false;
                }

                else

                {
                    MessageBox.Show("Could not find '" + cboxGameSelect.Text + "' in your Steam path!");

                    buttonSettings_Click(this, EventArgs.Empty);
                }
            }
        }


        private void buttonSettings_Click(object sender, EventArgs e)
        {
            se = new settings(this, se);
            se.Show();
            se.TopMost = true;
        }

        public void pBarMain_Change(int value)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { pBarMain_Change(value); });
                return;
            }

            pBarMain.Value = value;
        }


        public void labelInfo_Change(string info)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { labelInfo_Change(info); });
                return;
            }

            labelInfo.Text = (info);
            labelInfo.Refresh();
        }


        public void finished(Boolean success)
        {

            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { finished(success); });
                return;
            }

            if (success == true)
            {
                labelInfo.Text = "Finished fixing map!";
            }

            buttonFix.Enabled = true;
            buttonSettings.Enabled = true;
            cboxGameSelect.Enabled = true;
            buttonUpdates.Enabled = true;
        }
    }
}
