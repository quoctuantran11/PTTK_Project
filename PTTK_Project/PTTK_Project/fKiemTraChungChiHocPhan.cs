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
            if (KiemTraDuLieu(txbChungChi.Text, txbTrungTam.Text) == true)
            {
                MessageBox.Show("Xác thực hoàn tất", "Xác thực chứng chỉ");

            }
        }

        private bool KiemTraDuLieu(string chungchi, string noicap)
        {
            return KiemTraDB(chungchi, noicap);   
        }

        private bool KiemTraDB(string chungchi, string noicap)
        {
            string sql, tencc = "none";
            bool kq;
            cKetNoiDB.Con.Open();

            if (chbTrungTamNay.Checked == true)
            {
                sql = "select TenChungChi from ChungChiHocPhanTrungTam where MaChungChi = '" + chungchi + "'";

                tencc = cKetNoiDB.GetFieldValues(sql);
            }

            if (chbTrungTamKhac.Checked == true)
            {
                sql = "select TenChungChi from ChungChiHocPhanTrungTam where MaChungChi = '" + chungchi + "'" +
                    " and NoiCap = '" + noicap + "'";

                tencc = cKetNoiDB.GetFieldValues(sql);
            }

            if (tencc == "")
            {
                MessageBox.Show("Không tồn tại chứng chỉ này!");
                kq = false;
            }
            else if (tencc == "none")
            {
                MessageBox.Show("Error!!!");
                kq = false;
            }
            else
            {
                kq = true;
            }

            cKetNoiDB.Con.Close();
            return kq;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            bool ngoai = false;

            if (chbTrungTamNay.Checked == true)
            {
                ngoai = false;
            }

            if (chbTrungTamKhac.Checked == true)
            {
                ngoai = true;
            }

            GhiChungChi(txbHoTen.Text, txbChungChi.Text, ngoai);
        }

        private void GhiChungChi(string ten, string machungchi, bool ngoai)
        {
            if (ngoai)
            {
                ChungChiNgoaiTrungTam_HocVienDB(ten, machungchi);
            }
            else
            {
                ChungChiTrungTam_HocVienDB(ten, machungchi);
            }
        }

        private void ChungChiTrungTam_HocVienDB(string ten, string machungchi)
        {
            string sql, mahocvien;
            cKetNoiDB.Con.Open();
            sql = "Select MaHocVien from HocVien where HoTen = '" + ten + "'";
            mahocvien = cKetNoiDB.GetFieldValues(sql);

            sql = "Insert into ChungChiTrungTam_HocVien values (" + machungchi + "," + mahocvien + ")";
            cKetNoiDB.RunSQL(sql);
            MessageBox.Show("Ghi nhận thành công.");
            cKetNoiDB.Con.Close();
        }

        private void ChungChiNgoaiTrungTam_HocVienDB(string ten, string machungchi)
        {
            string sql, mahocvien;
            cKetNoiDB.Con.Open();
            sql = "Select MaHocVien from HocVien where HoTen = '" + ten + "'";
            mahocvien = cKetNoiDB.GetFieldValues(sql);

            sql = "Insert into ChungChiNgoaiTrungTam_HocVien values (" + machungchi + "," + mahocvien + ")";
            cKetNoiDB.RunSQL(sql);
            MessageBox.Show("Ghi nhận thành công.");
            cKetNoiDB.Con.Close();
        }
    }
}
