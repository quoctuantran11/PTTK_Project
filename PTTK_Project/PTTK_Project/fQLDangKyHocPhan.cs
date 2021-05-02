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
    public partial class fQLDangKyHocPhan : Form
    {
        public fQLDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaDKHP SuaDKHP = new fSuaDKHP();
            this.Hide();
            SuaDKHP.ShowDialog();
            this.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txbHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên học viên!", "Thông báo");
            }
            else
            {
                if (!KetQuaDangKyHocPhanBUS.Instance.TimKiem(dgvDKHP, txbHoten.Text))
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                }
            }
        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            KetQuaDangKyHocPhanBUS.Instance.HienToanBo(dgvDKHP);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KetQuaDangKyHocPhanBUS.Instance.XoaDKHP(dgvDKHP))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
        }

        private void Namcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Khoacmb.Text == "Khóa")
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoNam(dgvDKHP, txbHoten.Text, Namcmb.Text);
            }
            else
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoNamvaKhoa(dgvDKHP, txbHoten.Text, Namcmb.Text, Khoacmb.Text);
            }
        }

        private void Khoacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Namcmb.Text == "Năm")
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoKhoa(dgvDKHP, txbHoten.Text, Khoacmb.Text);
            }
            else
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoNamvaKhoa(dgvDKHP, txbHoten.Text, Namcmb.Text, Khoacmb.Text);
            }
        }
    }
}
