using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_Project
{
    public partial class fNVKeToan_UI : Form
    {
        public fNVKeToan_UI()
        {
            InitializeComponent();
        }

        private void btnGhiNhanHDDKCCQT_Click(object sender, EventArgs e)
        {
            fGhiNhanHDDKCCQT GN = new fGhiNhanHDDKCCQT();
            this.Hide();
            GN.ShowDialog();
            this.Show();
        }

        private void btnCapPhieuDuThi_Click(object sender, EventArgs e)
        {
            fCapPhieuDuThi PDT= new fCapPhieuDuThi();
            this.Hide();
            PDT.ShowDialog();
            this.Show();
        }

        private void btnGhiNhanHDDKHP_Click(object sender, EventArgs e)
        {
            fGhiNhanHDDKHP GN = new fGhiNhanHDDKHP();
            this.Hide();
            GN.ShowDialog();
            this.Show();
        }
    }
}
