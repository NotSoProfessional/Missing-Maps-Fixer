namespace Missing_Maps_Fixer
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelGameSelect = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gBoxSteamPath = new System.Windows.Forms.GroupBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTF2 = new System.Windows.Forms.Label();
            this.labelGmod = new System.Windows.Forms.Label();
            this.labelCSGO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxSteamPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStatus.Location = new System.Drawing.Point(10, 93);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(143, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status: Checking for status...";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 183);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(53, 27);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelGameSelect
            // 
            this.labelGameSelect.AutoSize = true;
            this.labelGameSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameSelect.Location = new System.Drawing.Point(16, 46);
            this.labelGameSelect.Name = "labelGameSelect";
            this.labelGameSelect.Size = new System.Drawing.Size(87, 18);
            this.labelGameSelect.TabIndex = 10;
            this.labelGameSelect.Text = "Steam path:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(3, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(130, 13);
            this.labelPath.TabIndex = 11;
            this.labelPath.Text = "Please select Steam path!";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(150, 9);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(70, 27);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 37);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Settings";
            // 
            // gBoxSteamPath
            // 
            this.gBoxSteamPath.Controls.Add(this.buttonChange);
            this.gBoxSteamPath.Controls.Add(this.labelPath);
            this.gBoxSteamPath.Location = new System.Drawing.Point(13, 50);
            this.gBoxSteamPath.Name = "gBoxSteamPath";
            this.gBoxSteamPath.Size = new System.Drawing.Size(222, 40);
            this.gBoxSteamPath.TabIndex = 14;
            this.gBoxSteamPath.TabStop = false;
            this.gBoxSteamPath.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Games detected:";
            // 
            // labelTF2
            // 
            this.labelTF2.AutoSize = true;
            this.labelTF2.Location = new System.Drawing.Point(16, 131);
            this.labelTF2.Name = "labelTF2";
            this.labelTF2.Size = new System.Drawing.Size(142, 13);
            this.labelTF2.TabIndex = 16;
            this.labelTF2.Text = "Team Fortress 2 - Not Found";
            // 
            // labelGmod
            // 
            this.labelGmod.AutoSize = true;
            this.labelGmod.Location = new System.Drawing.Point(16, 144);
            this.labelGmod.Name = "labelGmod";
            this.labelGmod.Size = new System.Drawing.Size(117, 13);
            this.labelGmod.TabIndex = 17;
            this.labelGmod.Text = "GarrysMod - Not Found";
            // 
            // labelCSGO
            // 
            this.labelCSGO.AutoSize = true;
            this.labelCSGO.Location = new System.Drawing.Point(16, 157);
            this.labelCSGO.Name = "labelCSGO";
            this.labelCSGO.Size = new System.Drawing.Size(214, 13);
            this.labelCSGO.TabIndex = 18;
            this.labelCSGO.Text = "Counter-Strike Global Offensive - Not Found";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 62);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 219);
            this.Controls.Add(this.labelCSGO);
            this.Controls.Add(this.labelGmod);
            this.Controls.Add(this.labelTF2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGameSelect);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.gBoxSteamPath);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing Maps Fixer - Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.gBoxSteamPath.ResumeLayout(false);
            this.gBoxSteamPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelGameSelect;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonChange;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox gBoxSteamPath;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTF2;
        private System.Windows.Forms.Label labelGmod;
        private System.Windows.Forms.Label labelCSGO;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}