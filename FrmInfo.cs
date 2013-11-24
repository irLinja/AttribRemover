using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AttribRemover
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void PBfb_Click(object sender, EventArgs e)
        {
            Process.Start("https://fb.com/ara.haghighat/");
        }

        private void PBgp_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/101114063116523865513/");
        }

        private void PBtw_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ArashHaghighat");
        }

        private void PbLicense_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gnu.org/licenses/gpl-3.0.html");
        }
    }
}
