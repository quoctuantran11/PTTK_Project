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
    public partial class fTraCuuKetQua : Form
    {
        public fTraCuuKetQua()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txbHocVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
            }
            else
            {
                if (!KetQuaDangKyHocPhanBUS.Instance.TimKiem(dgvKetQuaHoc, txbHocVien.Text))
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo");
                }
            }
        }
    }
}
