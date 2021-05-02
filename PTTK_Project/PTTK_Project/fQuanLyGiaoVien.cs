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
    public partial class fQuanLyGiaoVien : Form
    {
        public fQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemGiaoVien GV = new fThemGiaoVien();
            GV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaGiaoVien GV = new fSuaGiaoVien();
            GV.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên giáo viên!", "Thông báo");
            }
            else
            {
                if (!GiaoVienBUS.Instance.TimGiaoVien(dgvGiaoVien, txbHoTen.Text))
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo");
                }
            }
        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            GiaoVienBUS.Instance.HienToanBo(dgvGiaoVien);
        }
    }
}
