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
            int siso = 30, max = 31;
            string text = "Sĩ số của lớp hiện là " + siso + "/" + max;
            MessageBox.Show(text);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DangKy(txbHoTen.Text, cmbNam.Text, cmbKhoa.Text, cmbHocPhan.Text);
        }

        private void DangKy(string ten, string nam, string khoa, string hocphan)
        {
            KetQuaDangKyHocPhanDB(ten, nam, khoa, hocphan);
        }

        private void KetQuaDangKyHocPhanDB(string ten, string nam, string khoa, string hocphan)
        {
            cKetNoiDB.Con.Open();
            string mahocphan, mahocvien;

            string sql = "Select MaHocPhan from HocPhan where TenHocPhan = '" + hocphan + "'";
            mahocphan = cKetNoiDB.GetFieldValues(sql);

            sql = "Select MaHocvien from HocVien where HoTen = '" + ten + "'";
            mahocvien = cKetNoiDB.GetFieldValues(sql);

            sql = "Insert into KetQuaDangKyHocPhan values (" + mahocphan + "," + nam + ","
                + khoa + "," + mahocvien + ")";

            cKetNoiDB.RunSQL(sql);
            MessageBox.Show("Đăng ký học phần thành công.");
            cKetNoiDB.Con.Close();
        }

        private void fDKHocPhan_Load(object sender, EventArgs e)
        {
            cKetNoiDB.Con.Open();
            string sql = "Select HPM.MaHocPhan, HP.TenHocPhan from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan";
            cKetNoiDB.FillCombo(sql, cmbHocPhan, "MaHocPhan", "TenHocPhan");
            cmbHocPhan.SelectedIndex = -1;

            
            cKetNoiDB.Con.Close();
        }

        private void cmbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbLoaiHocPhan.Text = LayLoaiHocPhan(cmbHocPhan.Text);
        }

        private string LayLoaiHocPhan(string hocphan)
        {
            return LoaihocPhanDB(hocphan);
        }

        private string LoaihocPhanDB(string hocphan)
        {
            //cKetNoiDB.Con.Open();
            string sql = "select LoaiHocPhan from HocPhan where TenHocPhan = '" + hocphan + "'";
            string loaihocphan = cKetNoiDB.GetFieldValues(sql);
            //cKetNoiDB.Con.Close();
            return loaihocphan;

        }
    }
}
