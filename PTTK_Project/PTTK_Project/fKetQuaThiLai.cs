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
    public partial class fKetQuaThiLai : Form
    {
        public fKetQuaThiLai()
        {
            InitializeComponent();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            fNhapDiemThiLai nhapdiem = new fNhapDiemThiLai();
            this.Hide();
            nhapdiem.ShowDialog();
            this.Show();
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            fSuaDiemThiLai suadiem = new fSuaDiemThiLai();
            this.Hide();
            suadiem.ShowDialog();
            this.Show();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            KetQuaThiLaiBUS.Instance.HienThiToanBo(dgvKetQuaThiLai);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
            }
            else
            {
                if(!KetQuaThiLaiBUS.Instance.TimKiem(dgvKetQuaThiLai, txbHoTen.Text))
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo");
                }
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (KetQuaThiLaiBUS.Instance.XoaKetQua(dgvKetQuaThiLai))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi!!", "Thông báo");
            }
        }

        private void fKetQuaThiLai_Load(object sender, EventArgs e)
        {
            KetQuaThiLaiBUS.Instance.HienThiToanBo(dgvKetQuaThiLai);
        }
    }
}
