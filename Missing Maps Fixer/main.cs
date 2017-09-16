using System;
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

        public MainForm()
        {
            InitializeComponent();
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
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.CreateControl();
            linkLabelAuthor.Links.Add(0, 100, "www.youtube.com/notsoprofessional");
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }


        private void buttonUpdates_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonFix_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tBoxMap.Text, @"^[a-zA-Z]+$"))
            {
                labelInfo_Change("Please enter a map!");
            }

            else

            {
                fd = new fileDownload(this, fe);
                fd.map(tBoxMap.Text);

                pBarMain.Value = 0;
                buttonFix.Enabled = false;
            }
        }
    }
}
