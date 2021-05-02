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
    public partial class fNhapDiemThiLai : Form
    {
        public fNhapDiemThiLai()
        {
            InitializeComponent();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học viên!", "Thông báo");
                txbHoTen.Focus();
            }
            else if (txbCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số chứng minh nhân dân của học viên!", "Thông báo");
                txbCMND.Focus();
            }
            else if (txbDiemThiLai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm thi lại!", "Thông báo");
                txbDiemThiLai.Focus();
            }
            else
            {
                KetQuaThiLaiBUS.Instance.NhapDiem(txbMonHoc.Text,cmbNam.Text,cmbKhoa.Text,txbHoTen.Text,txbCMND.Text,txbDiemThiLai.Text,dtpNgayThiLai.Value);
                this.Close();
            }

            
        }

        
        private void txbMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (txbMonHoc.Text != "" && txbCMND.Text != "")
            {
                KetQuaThiLaiBUS.Instance.HienThiCombo(txbMonHoc.Text, txbCMND.Text, cmbNam, cmbKhoa);
            }
        }

        private void txbCMND_TextChanged(object sender, EventArgs e)
        {
            if (txbMonHoc.Text != "" && txbCMND.Text != "")
            {
                KetQuaThiLaiBUS.Instance.HienThiCombo(txbMonHoc.Text, txbCMND.Text, cmbNam, cmbKhoa);
            }
        }
    }
}
