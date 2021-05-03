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
    public partial class fHoaDonDKHP : Form
    {
        public fHoaDonDKHP()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mahocvien = txtMahocVien.Text;
            PTTK_BUS.HoaDonDKHPBUS.Instance.TimKiem(dgvHDDKHP, mahocvien);
        }

        private void fHoaDonDKHP_Load(object sender, EventArgs e)
        {
            PTTK_BUS.HoaDonDKHPBUS.Instance.Xem(dgvHDDKHP);
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            fGhiNhanHDDKHP GN = new fGhiNhanHDDKHP();
            this.Hide();
            GN.ShowDialog();
            this.Show();
        }
    }
}
