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
    public partial class fThemHocPhanMo : Form
    {
        public fThemHocPhanMo()
        {
            InitializeComponent();
        }



        private void Load_cmbNam()
        {
            cmbNam.DataSource = Nam_KhoaBUS.Instance.HienThiNam();
            cmbNam.DisplayMember = "Nam";
        }

        private void Load_cmbKhoa()
        {
           
            cmbKhoa.DataSource = Nam_KhoaBUS.Instance.HienThiKhoa();
            cmbKhoa.DisplayMember = "Khoa";
        }

        private void Load_cmbMaHocPhan()
        {
            cmbMaHocPhan.DataSource = HocPhanBUS.Instance.HienThiHocPhan();
            cmbMaHocPhan.DisplayMember = "MaHocPhan";
        }

        private void Load_cmbMaGiaoVien()
        {
            cmbMaGiaoVien.DataSource = GiaoVienBUS.Instance.HienThiGV();
            cmbMaGiaoVien.DisplayMember = "HoTenGV";
        }

        private void fThemHocPhanMo_Load(object sender, EventArgs e)
        {
            Load_cmbKhoa();
            Load_cmbNam();
            Load_cmbMaHocPhan();
            Load_cmbMaGiaoVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int nam = Int32.Parse(cmbNam.Text);
                int khoa = Int32.Parse(cmbKhoa.Text);
                int mahocphan = Int32.Parse(cmbMaHocPhan.Text);
                string phonghoc = (string)txtPhongHoc.Text;
                int soluongsv = Int32.Parse(txtSoluongSV.Text);
                string tengv = cmbMaGiaoVien.Text;

                if (HocPhanMoBUS.Instance.ThemHocPhanMo(mahocphan, nam, khoa, phonghoc, soluongsv, tengv))
                {
                    MessageBox.Show("Ghi nhận thành công!");
                }
                else
                {
                    MessageBox.Show("Ghi nhận thất bại!");
                }
            }

            catch
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu hoặc nhập thông tin đã tồn tại");
            }
        }
    }
}
