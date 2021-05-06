using PTTK_BUS;
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
    public partial class fQuanLyHocPhanMo : Form
    {
        public fQuanLyHocPhanMo()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemHocPhanMo HP = new fThemHocPhanMo();
            HP.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaHocPhanMo HP = new fSuaHocPhanMo();
            HP.ShowDialog();
        }

        private void Load_cmbMaHocPhan()
        {
            cmbMaHocPhan.DataSource = HocPhanMoBUS.Instance.HienThiHocPhan();
            cmbMaHocPhan.DisplayMember = "MaHocPhan";
        }

        private void Load_cmbNam()
        {
            cmbNam.DataSource = HocPhanMoBUS.Instance.HienThiHocPhan();
            cmbNam.DisplayMember = "Nam";
        }

        private void Load_cmbKhoa()
        {
            cmbKhoa.DataSource = HocPhanMoBUS.Instance.HienThiHocPhan();
            cmbKhoa.DisplayMember = "Khoa";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int mahocphan = Int32.Parse(cmbMaHocPhan.Text);
            int nam = Int32.Parse(cmbNam.Text);
            int khoa = Int32.Parse(cmbKhoa.Text);

            HocPhanMoBUS.Instance.HienThiDanhSachHocPhanMo2(dgvHocPhanMo, mahocphan, nam, khoa);
        }

        private void fQuanLyHocPhanMo_Load(object sender, EventArgs e)
        {
            Load_cmbMaHocPhan();
            Load_cmbNam();
            Load_cmbKhoa();

            HocPhanMoBUS.Instance.HienThiDanhSachHocPhanMo(dgvHocPhanMo);
        }

        private void cmbMaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            HocPhanMoBUS.Instance.HienThiDanhSachHocPhanMo(dgvHocPhanMo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (HocPhanMoBUS.Instance.XoaHocPhanMo(dgvHocPhanMo))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi!!!", "Thông báo");
            }
        }
    }
}
