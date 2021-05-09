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
    public partial class fThemHocPhan : Form
    {
        public fThemHocPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbTenHocPhan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học phần", "Thông báo");
                txbTenHocPhan.Focus();
            }
            else if (txbLoaiHocPhan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập loại học phần", "Thông báo");
                txbLoaiHocPhan.Focus();
            }
            else
            {
                if(!HocPhanBUS.Instance.GhiHocPhan(txbTenHocPhan.Text, txbLoaiHocPhan.Text))
                {
                    MessageBox.Show("Lỗi!!!", "Thông báo");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
