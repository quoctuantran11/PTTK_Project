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
            if(Khoacmb.SelectedIndex == -1 && Namcmb.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.HienToanBo(dgvDKHP);
            }    
            else if (Khoacmb.SelectedIndex == -1)
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
            if (Khoacmb.SelectedIndex == -1 && Namcmb.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.HienToanBo(dgvDKHP);
            }
            else if (Namcmb.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoKhoa(dgvDKHP, txbHoten.Text, Khoacmb.Text);
            }
            else
            {
                KetQuaDangKyHocPhanBUS.Instance.HienTheoNamvaKhoa(dgvDKHP, txbHoten.Text, Namcmb.Text, Khoacmb.Text);
            }
        }

        private void fQLDangKyHocPhan_Load(object sender, EventArgs e)
        {
            KetQuaDangKyHocPhanBUS.Instance.HienToanBo(dgvDKHP);

            Namcmb.SelectedIndexChanged -= Namcmb_SelectedIndexChanged;
            Namcmb.DataSource = KetQuaDangKyHocPhanBUS.Instance.HienNamvaKhoa();
            Namcmb.DisplayMember = "Nam";
            Namcmb.SelectedIndexChanged += Namcmb_SelectedIndexChanged;

            Khoacmb.SelectedIndexChanged -= Khoacmb_SelectedIndexChanged;
            Khoacmb.DataSource = KetQuaDangKyHocPhanBUS.Instance.HienNamvaKhoa();
            Khoacmb.DisplayMember = "Khoa";
            Khoacmb.SelectedIndexChanged += Khoacmb_SelectedIndexChanged;
        }
    }
}
