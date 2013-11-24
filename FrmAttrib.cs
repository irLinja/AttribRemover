/*<one line to give the program's name and a brief idea of what it does.>
    Copyright (C) <2013>  <Arash Haghighat>

    AttribRemover is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AttribRemover
{
    public partial class FrmAttrib : Form
    {
        public FrmAttrib()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.PbRefresh.Cursor = Cursors.Hand;
            this.PbRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #region Constants
        const string Attribute = "attrib";
        const string System = " -s";
        const string Hidden = " -h";
        const string ReadOnly = " -r";
        const string Archive = " -a";
        const string FilesOnly = " /s";
        const string FoldersOnly = " /d";
        const string All = " /s /d";

        #endregion

        private void GetDrives()
        {
            CboDriveName.Items.Clear();
            DriveInfo[] ListDrives = DriveInfo.GetDrives();

            foreach (DriveInfo Drive in ListDrives)
            {
                if (Drive.DriveType == DriveType.Removable || Drive.DriveType == DriveType.Fixed)
                {
                    CboDriveName.Items.Add(Drive.Name.ToString());
                    CboDriveName.Text = string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDrives();
            this.Height -= Pbar.Height;
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (CboDriveName.Text != string.Empty && Regex.IsMatch(CboDriveName.Text, @"^([a-zA-Z])\:\\$"))
            {
                string DriveName = CboDriveName.Text;
                string Command = string.Concat(DriveName.Remove(DriveName.Length - 1, 1), "&", Attribute);
                if (CbHidden.Checked == false && CbSystem.Checked == false && CbArchive.Checked == false && CbReadOnly.Checked == false)
                    MessageBox.Show("Please select an attribiute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (CbHidden.Checked)
                        Command += Hidden;
                    if (CbSystem.Checked)
                        Command += System;
                    if (CbArchive.Checked)
                        Command += Archive;
                    if (CbReadOnly.Checked)
                        Command += ReadOnly;
                    if (RdbFolders.Checked)
                        Command += FoldersOnly;
                    if (RdbFiles.Checked)
                        Command += FilesOnly;
                    if (RdbAll.Checked)
                        Command += All;
                    try
                    {
                        ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + Command);
                        procStartInfo.UseShellExecute = false;
                        procStartInfo.CreateNoWindow = true;
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo = procStartInfo;
                        proc.EnableRaisingEvents = true;
                        proc.Start();
                        this.Enabled = false;
                        Pbar.Visible = true;
                        this.Height += Pbar.Height;
                        proc.WaitForExit();
                        MessageBox.Show("Done Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Enabled = true;
                        Pbar.Visible = false;
                        this.Height -= Pbar.Height;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Error");
                    }
                }
            }
            else
                MessageBox.Show("Please select a drive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PbRefresh_Click(object sender, EventArgs e)
        {
            GetDrives();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo Info = new FrmInfo();
            Info.ShowDialog();
        }
    }
}