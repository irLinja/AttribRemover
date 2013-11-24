using System.Windows.Forms;
namespace AttribRemover
{
    partial class FrmAttrib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttrib));
            this.RdbAll = new System.Windows.Forms.RadioButton();
            this.RdbFolders = new System.Windows.Forms.RadioButton();
            this.RdbFiles = new System.Windows.Forms.RadioButton();
            this.CbReadOnly = new System.Windows.Forms.CheckBox();
            this.CbArchive = new System.Windows.Forms.CheckBox();
            this.CbSystem = new System.Windows.Forms.CheckBox();
            this.CbHidden = new System.Windows.Forms.CheckBox();
            this.CboDriveName = new System.Windows.Forms.ComboBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.PbRefresh = new System.Windows.Forms.PictureBox();
            this.Pbar = new System.Windows.Forms.ProgressBar();
            this.BtnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbAll
            // 
            this.RdbAll.AutoSize = true;
            this.RdbAll.Checked = true;
            this.RdbAll.Location = new System.Drawing.Point(12, 112);
            this.RdbAll.Name = "RdbAll";
            this.RdbAll.Size = new System.Drawing.Size(112, 17);
            this.RdbAll.TabIndex = 17;
            this.RdbAll.TabStop = true;
            this.RdbAll.Text = "All files and folders";
            this.RdbAll.UseVisualStyleBackColor = true;
            // 
            // RdbFolders
            // 
            this.RdbFolders.AutoSize = true;
            this.RdbFolders.Location = new System.Drawing.Point(12, 88);
            this.RdbFolders.Name = "RdbFolders";
            this.RdbFolders.Size = new System.Drawing.Size(83, 17);
            this.RdbFolders.TabIndex = 16;
            this.RdbFolders.Text = "Folders Only";
            this.RdbFolders.UseVisualStyleBackColor = true;
            // 
            // RdbFiles
            // 
            this.RdbFiles.AutoSize = true;
            this.RdbFiles.Location = new System.Drawing.Point(12, 64);
            this.RdbFiles.Name = "RdbFiles";
            this.RdbFiles.Size = new System.Drawing.Size(70, 17);
            this.RdbFiles.TabIndex = 15;
            this.RdbFiles.Text = "Files Only";
            this.RdbFiles.UseVisualStyleBackColor = true;
            // 
            // CbReadOnly
            // 
            this.CbReadOnly.AutoSize = true;
            this.CbReadOnly.Location = new System.Drawing.Point(200, 39);
            this.CbReadOnly.Name = "CbReadOnly";
            this.CbReadOnly.Size = new System.Drawing.Size(74, 17);
            this.CbReadOnly.TabIndex = 14;
            this.CbReadOnly.Text = "Read-only";
            this.CbReadOnly.UseVisualStyleBackColor = true;
            // 
            // CbArchive
            // 
            this.CbArchive.AutoSize = true;
            this.CbArchive.Location = new System.Drawing.Point(134, 39);
            this.CbArchive.Name = "CbArchive";
            this.CbArchive.Size = new System.Drawing.Size(62, 17);
            this.CbArchive.TabIndex = 13;
            this.CbArchive.Text = "Archive";
            this.CbArchive.UseVisualStyleBackColor = true;
            // 
            // CbSystem
            // 
            this.CbSystem.AutoSize = true;
            this.CbSystem.Location = new System.Drawing.Point(70, 39);
            this.CbSystem.Name = "CbSystem";
            this.CbSystem.Size = new System.Drawing.Size(60, 17);
            this.CbSystem.TabIndex = 12;
            this.CbSystem.Text = "System";
            this.CbSystem.UseVisualStyleBackColor = true;
            // 
            // CbHidden
            // 
            this.CbHidden.AutoSize = true;
            this.CbHidden.Location = new System.Drawing.Point(12, 39);
            this.CbHidden.Name = "CbHidden";
            this.CbHidden.Size = new System.Drawing.Size(60, 17);
            this.CbHidden.TabIndex = 11;
            this.CbHidden.Text = "Hidden";
            this.CbHidden.UseVisualStyleBackColor = true;
            // 
            // CboDriveName
            // 
            this.CboDriveName.FormattingEnabled = true;
            this.CboDriveName.Location = new System.Drawing.Point(12, 12);
            this.CboDriveName.Name = "CboDriveName";
            this.CboDriveName.Size = new System.Drawing.Size(172, 21);
            this.CboDriveName.TabIndex = 10;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(221, 12);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(55, 21);
            this.BtnExecute.TabIndex = 9;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // PbRefresh
            // 
            this.PbRefresh.Image = global::AttribRemover.Properties.Resources._1380987407_refresh_shield;
            this.PbRefresh.Location = new System.Drawing.Point(190, 12);
            this.PbRefresh.Name = "PbRefresh";
            this.PbRefresh.Size = new System.Drawing.Size(21, 21);
            this.PbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PbRefresh.TabIndex = 21;
            this.PbRefresh.TabStop = false;
            this.PbRefresh.Click += new System.EventHandler(this.PbRefresh_Click);
            // 
            // Pbar
            // 
            this.Pbar.Location = new System.Drawing.Point(12, 135);
            this.Pbar.Name = "Pbar";
            this.Pbar.Size = new System.Drawing.Size(264, 23);
            this.Pbar.Style = ProgressBarStyle.Marquee;
            this.Pbar.TabIndex = 22;
            this.Pbar.Visible = false;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(221, 108);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(55, 21);
            this.BtnInfo.TabIndex = 23;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // FrmAttrib
            // 
            this.AcceptButton = this.BtnExecute;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.Pbar);
            this.Controls.Add(this.PbRefresh);
            this.Controls.Add(this.RdbAll);
            this.Controls.Add(this.RdbFolders);
            this.Controls.Add(this.RdbFiles);
            this.Controls.Add(this.CbReadOnly);
            this.Controls.Add(this.CbArchive);
            this.Controls.Add(this.CbSystem);
            this.Controls.Add(this.CbHidden);
            this.Controls.Add(this.CboDriveName);
            this.Controls.Add(this.BtnExecute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAttrib";
            this.Text = "Attribute Remover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbAll;
        private System.Windows.Forms.RadioButton RdbFolders;
        private System.Windows.Forms.RadioButton RdbFiles;
        private System.Windows.Forms.CheckBox CbReadOnly;
        private System.Windows.Forms.CheckBox CbArchive;
        private System.Windows.Forms.CheckBox CbSystem;
        private System.Windows.Forms.CheckBox CbHidden;
        private System.Windows.Forms.ComboBox CboDriveName;
        private System.Windows.Forms.Button BtnExecute;
        private PictureBox PbRefresh;
        private ProgressBar Pbar;
        private Button BtnInfo;
    }
}

