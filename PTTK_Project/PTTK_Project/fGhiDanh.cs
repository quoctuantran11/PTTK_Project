using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PTTK_Project;
using PTTK_BUS;

namespace PTTK_Project
{
    public partial class fGhiDanh : Form
    {
        public fGhiDanh()
        {
            InitializeComponent();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            fDKHocPhan hocphan = new fDKHocPhan();
            this.Hide();
            hocphan.ShowDialog();
            this.Show();
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (txbCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số chứng minh nhân dân!", "Thông báo");
                txbCMND.Focus();
            }
            else
            {
                if (!HocVienBUS.Instance.KiemTraTrungLap(txbCMND.Text))
                {
                    if (txbHoTen.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
                        txbHoTen.Focus();
                    }
                    else if (cmbGioiTinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn giới tính!", "Thông báo");
                        cmbGioiTinh.Focus();
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
                    else
                    {
                        if (!HocVienBUS.Instance.ThemHocVien(txbHoTen.Text, cmbGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyyMMdd"), txbCMND.Text, txbSDT.Text, txbDiaChi.Text))
                        {
                            MessageBox.Show("Lỗi!!!", "Thông báo");
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tìm thấy dữ liệu!", "Thông báo");
                }
            }
        }
        
        

        
    }
}
