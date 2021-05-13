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
    public partial class fDKHocPhan : Form
    {
        public fDKHocPhan()
        {
            InitializeComponent();
        }

        private void btnGNCC_Click(object sender, EventArgs e)
        {
            fTiepNhanChungChiHocPhan kiemtra = new fTiepNhanChungChiHocPhan();
            this.Hide();
            kiemtra.ShowDialog();
            this.Show();
        }

        private void btnKiemTraSiSo_Click(object sender, EventArgs e)
        {
            if (cmbHocPhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn học phần!", "Thông báo");
                
            }
            else
            {
                if (cmbNam.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn năm!", "Thông báo");
                }
                else
                {
                    if (cmbKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn khóa!", "Thông báo");
                    }
                    else
                    {
                        string sisotoida = KetQuaDangKyHocPhanBUS.Instance.LaySiSo(cmbNam.Text, cmbKhoa.Text, cmbHocPhan.Text);
                        string sisodk = KetQuaDangKyHocPhanBUS.Instance.LaySiSoDK(cmbNam.Text, cmbKhoa.Text, cmbHocPhan.Text);


                        string thongbao = "Sĩ số của lớp hiện tại là " + sisodk + "/" + sisotoida;

                        MessageBox.Show(thongbao, "Thông báo");

                    }
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txbCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số CMND của học viên!", "Thông báo");
                txbCMND.Focus();
            }
            else if (cmbNam.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn năm!", "Thông báo");
            }
            else if (cmbKhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khóa!", "Thông báo");
            }
            else if (cmbHocPhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn học phần!", "Thông báo");

            }
            else
            {
                if (KetQuaDangKyHocPhanBUS.Instance.DangKyHP(txbCMND.Text, cmbNam.Text, cmbKhoa.Text, cmbHocPhan.Text))
                {
                    MessageBox.Show("Hoàn tất đăng ký học phần!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi!!!", "Thông báo");
                }
            }
        }

        private void fDKHocPhan_Load(object sender, EventArgs e)
        {
            cmbNam.DataSource = Nam_KhoaBUS.Instance.HienThiNam();
            cmbNam.DisplayMember = "Nam";
            cmbNam.SelectedIndex = -1;

            cmbKhoa.DataSource = Nam_KhoaBUS.Instance.HienThiKhoa();
            cmbKhoa.DisplayMember = "Khoa";
            cmbKhoa.SelectedIndex = -1;
        }

        private void cmbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbLoaiHocPhan.Text = HocPhanMoBUS.Instance.HienThiLoaiHocPhan(cmbHocPhan.Text);

            if(txbLoaiHocPhan.Text == "Co ban")
            {
                btnGNCC.Enabled = false;
            }
            else
            {
                btnGNCC.Enabled = true;
            }
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedIndex != -1 && cmbKhoa.SelectedIndex != -1)
            {
                cmbHocPhan.DataSource = HocPhanMoBUS.Instance.HienThiHocPhanMo(cmbNam.Text, cmbKhoa.Text);
                cmbHocPhan.DisplayMember = "TenHocPhan";
                cmbHocPhan.ValueMember = "MaHocPhan";
                cmbHocPhan.SelectedIndex = -1;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedIndex != -1 && cmbKhoa.SelectedIndex != -1)
            {
                cmbHocPhan.DataSource = HocPhanMoBUS.Instance.HienThiHocPhanMo(cmbNam.Text, cmbKhoa.Text);
                cmbHocPhan.DisplayMember = "TenHocPhan";
                cmbHocPhan.ValueMember = "MaHocPhan";
                cmbHocPhan.SelectedIndex = -1;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (!HocVienBUS.Instance.KiemTraTrungLap(txbCMND.Text))
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tìm thấy dữ liệu!", "Thông báo");
            }
        }
    }
}
