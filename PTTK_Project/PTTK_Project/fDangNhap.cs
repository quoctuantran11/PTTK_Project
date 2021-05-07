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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo");
                txbTenDangNhap.Focus();
            }
            else
            {
                if (txbMatKhau.Text == "")
                {
                    MessageBox.Show("Xin hãy nhập mật khẩu!", "Thông báo");
                    txbMatKhau.Focus();
                }
                else
                {
                    if (txbTenDangNhap.Text == "bpvp")
                    {
                        if (txbMatKhau.Text != "vp")
                        {
                            MessageBox.Show("Sai mật khẩu!", "Thông báo");
                            txbMatKhau.Focus();
                        }
                        else
                        {
                            fBoPhanVanPhong_UI VP = new fBoPhanVanPhong_UI();
                            this.Hide();
                            VP.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (txbTenDangNhap.Text == "bptn")
                    {
                        if (txbMatKhau.Text != "tn")
                        {
                            MessageBox.Show("Sai mật khẩu!", "Thông báo");
                            txbMatKhau.Focus();
                        }
                        else
                        {
                            fNVTiepNhan_UI TN = new fNVTiepNhan_UI();
                            this.Hide();
                            TN.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (txbTenDangNhap.Text == "bpkt")
                    {
                        if (txbMatKhau.Text != "kt")
                        {
                            MessageBox.Show("Sai mật khẩu!", "Thông báo");
                            txbMatKhau.Focus();
                        }
                        else
                        {
                            fNVKeToan_UI KT = new fNVKeToan_UI();
                            this.Hide();
                            KT.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Thông báo");
                        txbTenDangNhap.Focus();
                    }
                }
            }
        }
    }
}
