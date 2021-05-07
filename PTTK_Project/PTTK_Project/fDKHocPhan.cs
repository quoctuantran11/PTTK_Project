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
            fKiemTraChungChiHocPhan kiemtra = new fKiemTraChungChiHocPhan();
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
            if(KetQuaDangKyHocPhanBUS.Instance.DangKyHP(txbHoTen.Text, cmbNam.Text, cmbKhoa.Text, cmbHocPhan.Text))
            {
                MessageBox.Show("Hoàn tất đăng ký học phần!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
        }

        private void fDKHocPhan_Load(object sender, EventArgs e)
        {
            cmbHocPhan.DataSource = HocPhanMoBUS.Instance.HienThiHocPhan();
            cmbHocPhan.DisplayMember = "TenHocPhan";
            cmbHocPhan.ValueMember = "MaHocPhan";

            cmbHocPhan.SelectedIndex = -1;
        }

        private void cmbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbLoaiHocPhan.Text = HocPhanMoBUS.Instance.HienThiLoaiHocPhan(cmbHocPhan.Text);
        }
    }
}
