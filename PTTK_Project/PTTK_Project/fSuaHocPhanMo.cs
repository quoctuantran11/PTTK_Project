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
    public partial class fSuaHocPhanMo : Form
    {
        public fSuaHocPhanMo()
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
            cmbMaGiaoVien.DataSource = GiaoVienBUS.Instance.HienThiMaGV();
            cmbMaGiaoVien.DisplayMember = "MaGiaoVien";
        }

        private void fSuaHocPhanMo_Load(object sender, EventArgs e)
        {
            Load_cmbKhoa();
            Load_cmbNam();
            Load_cmbMaHocPhan();
            Load_cmbMaGiaoVien();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int nam = Int32.Parse(cmbNam.Text);
                int khoa = Int32.Parse(cmbKhoa.Text);
                int mahocphan = Int32.Parse(cmbMaHocPhan.Text);
                string phonghoc = (string)txtPhong.Text;
                int soluongsv = Int32.Parse(txtSoluongSV.Text);
                int magv = Int32.Parse(cmbMaGiaoVien.Text);

                if (HocPhanMoBUS.Instance.SuaHocPhanMo(mahocphan, nam, khoa, phonghoc, soluongsv, magv))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }

            catch
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu hoặc nhập thông tin không tồn tại");
            }
        }
    }
}
