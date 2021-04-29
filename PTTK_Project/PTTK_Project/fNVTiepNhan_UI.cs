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
    public partial class fNVTiepNhan_UI : Form
    {
        public fNVTiepNhan_UI()
        {
            InitializeComponent();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            fDKHocPhan dkhp = new fDKHocPhan();
            this.Hide();
            dkhp.ShowDialog();
            this.Show();           
        }

        private void btnGNHV_Click(object sender, EventArgs e)
        {
            fGhiDanh ghidanh = new fGhiDanh();
            this.Hide();
            ghidanh.ShowDialog();
            this.Show();
        }

        private void btnGNNTDT_Click(object sender, EventArgs e)
        {
            fDangKyChungChiQuocTe ccquocte = new fDangKyChungChiQuocTe();
            this.Hide();
            ccquocte.ShowDialog();
            this.Show();
        }

        private void btnXKQTL_Click(object sender, EventArgs e)
        {
            fXemKQTL kqtl = new fXemKQTL();
            this.Hide();
            kqtl.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fThongKeHocVien thongke = new fThongKeHocVien();
            this.Hide();
            thongke.ShowDialog();
            this.Show();
        }
    }
}
