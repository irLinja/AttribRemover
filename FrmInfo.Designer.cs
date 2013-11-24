namespace AttribRemover
{
    partial class FrmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.PbLicense = new System.Windows.Forms.PictureBox();
            this.PBtw = new System.Windows.Forms.PictureBox();
            this.PBgp = new System.Windows.Forms.PictureBox();
            this.PBfb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBtw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfb)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLicense
            // 
            this.PbLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbLicense.Image = global::AttribRemover.Properties.Resources.gplv3_127x51;
            this.PbLicense.Location = new System.Drawing.Point(194, 117);
            this.PbLicense.Name = "PbLicense";
            this.PbLicense.Size = new System.Drawing.Size(127, 51);
            this.PbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbLicense.TabIndex = 3;
            this.PbLicense.TabStop = false;
            this.PbLicense.Click += new System.EventHandler(this.PbLicense_Click);
            // 
            // PBtw
            // 
            this.PBtw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBtw.Image = global::AttribRemover.Properties.Resources._1379854819_twitter_square;
            this.PBtw.Location = new System.Drawing.Point(133, 117);
            this.PBtw.Name = "PBtw";
            this.PBtw.Size = new System.Drawing.Size(55, 50);
            this.PBtw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBtw.TabIndex = 2;
            this.PBtw.TabStop = false;
            this.PBtw.Click += new System.EventHandler(this.PBtw_Click);
            // 
            // PBgp
            // 
            this.PBgp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBgp.Image = global::AttribRemover.Properties.Resources._1379854798_google_square;
            this.PBgp.Location = new System.Drawing.Point(72, 117);
            this.PBgp.Name = "PBgp";
            this.PBgp.Size = new System.Drawing.Size(55, 50);
            this.PBgp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBgp.TabIndex = 1;
            this.PBgp.TabStop = false;
            this.PBgp.Click += new System.EventHandler(this.PBgp_Click);
            // 
            // PBfb
            // 
            this.PBfb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBfb.Image = global::AttribRemover.Properties.Resources._1379854713_Facebook_alt_1;
            this.PBfb.InitialImage = null;
            this.PBfb.Location = new System.Drawing.Point(11, 117);
            this.PBfb.Name = "PBfb";
            this.PBfb.Size = new System.Drawing.Size(55, 50);
            this.PBfb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBfb.TabIndex = 0;
            this.PBfb.TabStop = false;
            this.PBfb.Click += new System.EventHandler(this.PBfb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed by Arash Haghighat\r\narashhaghighat@gmail.com";
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbLicense);
            this.Controls.Add(this.PBtw);
            this.Controls.Add(this.PBgp);
            this.Controls.Add(this.PBfb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.PbLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBtw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBfb;
        private System.Windows.Forms.PictureBox PBgp;
        private System.Windows.Forms.PictureBox PBtw;
        private System.Windows.Forms.PictureBox PbLicense;
        private System.Windows.Forms.Label label1;
    }
}