namespace Missing_Maps_Fixer
{
    partial class MainForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGameSelect = new System.Windows.Forms.Label();
            this.cboxGameSelect = new System.Windows.Forms.ComboBox();
            this.tBoxMap = new System.Windows.Forms.TextBox();
            this.labelMapName = new System.Windows.Forms.Label();
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonUpdates = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAuthorInfo = new System.Windows.Forms.Label();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pBarMain = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(37, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(280, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Missing Maps Fixer";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(115, 39);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(108, 13);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "by NotSoProfessional";
            // 
            // labelGameSelect
            // 
            this.labelGameSelect.AutoSize = true;
            this.labelGameSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameSelect.Location = new System.Drawing.Point(9, 64);
            this.labelGameSelect.Name = "labelGameSelect";
            this.labelGameSelect.Size = new System.Drawing.Size(116, 18);
            this.labelGameSelect.TabIndex = 2;
            this.labelGameSelect.Text = "Game selection:";
            // 
            // cboxGameSelect
            // 
            this.cboxGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGameSelect.FormattingEnabled = true;
            this.cboxGameSelect.Items.AddRange(new object[] {
            "Team Fortress 2",
            "GarrysMod",
            "Counter-Strike Global Offensive"});
            this.cboxGameSelect.Location = new System.Drawing.Point(12, 85);
            this.cboxGameSelect.Name = "cboxGameSelect";
            this.cboxGameSelect.Size = new System.Drawing.Size(211, 21);
            this.cboxGameSelect.TabIndex = 3;
            // 
            // tBoxMap
            // 
            this.tBoxMap.Location = new System.Drawing.Point(12, 134);
            this.tBoxMap.Name = "tBoxMap";
            this.tBoxMap.Size = new System.Drawing.Size(330, 20);
            this.tBoxMap.TabIndex = 4;
            // 
            // labelMapName
            // 
            this.labelMapName.AutoSize = true;
            this.labelMapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapName.Location = new System.Drawing.Point(9, 113);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(85, 18);
            this.labelMapName.TabIndex = 5;
            this.labelMapName.Text = "Map Name:";
            // 
            // buttonFix
            // 
            this.buttonFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFix.Location = new System.Drawing.Point(12, 209);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(104, 27);
            this.buttonFix.TabIndex = 6;
            this.buttonFix.Text = "Fix";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // buttonUpdates
            // 
            this.buttonUpdates.Location = new System.Drawing.Point(122, 209);
            this.buttonUpdates.Name = "buttonUpdates";
            this.buttonUpdates.Size = new System.Drawing.Size(102, 27);
            this.buttonUpdates.TabIndex = 7;
            this.buttonUpdates.Text = "Check for updates";
            this.buttonUpdates.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(289, 209);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(53, 27);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelAuthorInfo
            // 
            this.labelAuthorInfo.AutoSize = true;
            this.labelAuthorInfo.Location = new System.Drawing.Point(29, 243);
            this.labelAuthorInfo.Name = "labelAuthorInfo";
            this.labelAuthorInfo.Size = new System.Drawing.Size(288, 13);
            this.labelAuthorInfo.TabIndex = 9;
            this.labelAuthorInfo.Text = "Like this software? Support and check out the creator here:";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Location = new System.Drawing.Point(92, 256);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(182, 13);
            this.linkLabelAuthor.TabIndex = 10;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "www.youtube.com/notsoprofessional";
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(9, 278);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(133, 13);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "Version: 0.0.0.1 C# Edition";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 165);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(115, 13);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "Waiting for fix to start...";
            // 
            // pBarMain
            // 
            this.pBarMain.Location = new System.Drawing.Point(12, 181);
            this.pBarMain.Name = "pBarMain";
            this.pBarMain.Size = new System.Drawing.Size(330, 23);
            this.pBarMain.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 45);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 38);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 44);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(230, 209);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(53, 27);
            this.buttonSettings.TabIndex = 17;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 300);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pBarMain);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.labelAuthorInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpdates);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.cboxGameSelect);
            this.Controls.Add(this.labelGameSelect);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBoxMap);
            this.Controls.Add(this.labelMapName);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing Maps Fixer by NotSoProfessional";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGameSelect;
        private System.Windows.Forms.ComboBox cboxGameSelect;
        private System.Windows.Forms.Label labelMapName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAuthorInfo;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.Label labelVersion;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.TextBox tBoxMap;
        public System.Windows.Forms.ProgressBar pBarMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button buttonFix;
        public System.Windows.Forms.Button buttonUpdates;
        public System.Windows.Forms.Button buttonSettings;
    }
}