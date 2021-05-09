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
    public partial class fThemGiaoVien : Form
    {
        public fThemGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "Thông báo");
                txbHoTen.Focus();
            }
            else if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo");
                txbDiaChi.Focus();
            }
            else if (cmbPhai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Thông báo");
                cmbPhai.Focus();
            }
            else if (txbSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo");
                txbSDT.Focus();
            }
            else
            {
                GiaoVienBUS.Instance.ThemGiaoVien(txbHoTen.Text, txbDiaChi.Text, dtpNgaySinh.Value.ToString("yyyyMMdd"), cmbPhai.Text, txbSDT.Text);
                this.Close();
            }
        }
    }
}
