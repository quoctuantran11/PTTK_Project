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
    public partial class fKiemTraChungChiHocPhan : Form
    {
        public fKiemTraChungChiHocPhan()
        {
            InitializeComponent();
        }

        private void chbTrungTamNay_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTrungTamNay.Checked == true)
            {
                chbTrungTamKhac.Checked = false;
                lblTrungTam.Visible = false;
                txbTrungTam.Visible = false;
            }
        }

        private void chbTrungTamKhac_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTrungTamKhac.Checked == true)
            {
                chbTrungTamNay.Checked = false;
                lblTrungTam.Visible = true;
                txbTrungTam.Visible = true;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txbChungChi.Text != "")
            {
                if (chbTrungTamNay.Checked == true)
                {
                    if (ChungChiHocPhanTrungTamBUS.Instance.KiemTraDuLieu(txbChungChi.Text))
                    {
                        MessageBox.Show("Xác thực hoàn tất!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại chứng chỉ này!", "Thông báo");
                    }
                }

                if (chbTrungTamKhac.Checked == true)
                {
                    if (txbTrungTam.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập trung tâm cấp chứng chỉ của bạn", "Thông báo");
                    }
                    else
                    {
                        if (ChungChiHocPhanNgoaiTrungTamBUS.Instance.KiemTraDuLieu(txbChungChi.Text, txbTrungTam.Text))
                        {
                            MessageBox.Show("Xác thực hoàn tất!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại chứng chỉ này!", "Thông báo");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã chứng chỉ học phần cơ bản!", "Thông báo");
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên học viên!", "Thông báo");
            }
            else
            {
                if (chbTrungTamNay.Checked == true)
                {
                    ChungChiTrungTam_HocVienBUS.Instance.GhiHoSo(txbHoTen.Text, txbChungChi.Text);
                    this.Close();
                }

                if (chbTrungTamKhac.Checked == true)
                {
                    ChungChiNgoaiTrungTam_HocVienBUS.Instance.GhiHoSo(txbHoTen.Text, txbChungChi.Text);
                    this.Close();
                }
            }
        }
    }
}
