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
    public partial class fDangKyChungChiQuocTe : Form
    {
        public fDangKyChungChiQuocTe()
        {
            InitializeComponent();
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            fXemLichThi lichthi = new fXemLichThi();
            lichthi.ShowDialog();
        }

        private void HoanTatbtn_Click(object sender, EventArgs e)
        {
            if (txbHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
                txbHoten.Focus();
            }
            else if (cmbGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Thông báo");
                cmbGioiTinh.Focus();
            }
            else if (txbCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số chứng minh nhân dân!", "Thông báo");
                txbCMND.Focus();
            }
            else if (txbSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo");
                txbSDT.Focus();
            }
            else if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo");
                txbDiaChi.Focus();
            }
            else if (txbTenChungChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên chứng chỉ!", "Thông báo");
                txbTenChungChi.Focus();
            }
            else if (cmbDotThi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đợt thi!", "Thông báo");
                cmbDotThi.Focus();
            }
            else
            {
                NguoiThamDuThiBUS.Instance.GhiNhan(txbHoten.Text, cmbGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyyMMdd"), txbCMND.Text, txbSDT.Text, txbDiaChi.Text);
                ChiTietLichThiBUS.Instance.GhiNhan(cmbDotThi.Text, txbTenChungChi.Text, txbHoten.Text);

                MessageBox.Show("Hoàn tất ghi danh!", "Thông báo");
            }
        }

        private void fDangKyChungChiQuocTe_Load(object sender, EventArgs e)
        {
            cmbDotThi.DataSource = ChiTietLichThiBUS.Instance.HienThiCombo();
            cmbDotThi.DisplayMember = cmbDotThi.ValueMember = "MaSoDotThi";
        }
    }
}
