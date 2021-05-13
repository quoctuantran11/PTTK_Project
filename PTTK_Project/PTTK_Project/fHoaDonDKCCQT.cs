using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_BUS;

namespace PTTK_Project
{
    public partial class fHoaDonDKCCQT : Form
    {
        public fHoaDonDKCCQT()
        {
            InitializeComponent();
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            fGhiNhanHDDKCCQT TN = new fGhiNhanHDDKCCQT();
            this.Hide();
            TN.ShowDialog();
            this.Show();
        }

        private void fHoaDonDKCCQT_Load(object sender, EventArgs e)
        {
           HoaDonDKChungChiQuocTe.Instance.Xem(dgvHDDKCCQT);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mathisinh = txtMaThiSinh.Text;
            HoaDonDKChungChiQuocTe.Instance.TimKiem(dgvHDDKCCQT, mathisinh);
        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            HoaDonDKChungChiQuocTe.Instance.Xem(dgvHDDKCCQT);
        }
    }
}
