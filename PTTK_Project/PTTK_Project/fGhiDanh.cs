using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PTTK_Project;

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
            if(KiemTraTrungLap(txbHoTen.Text,txbCMND.Text) == true)
            {
                ThemHocVien(txbHoTen.Text, cmbGioiTinh.Text, dtpNgaySinh.Value, txbCMND.Text, txbSDT.Text, txbDiaChi.Text);
            }
            else
            {
                MessageBox.Show("Học viên này đã đăng ký rồi.");
            }
        }

        private bool KiemTraTrungLap(string ten, string Socmnd)
        {

            return DocThongTin(ten, Socmnd);
        }

        private void ThemHocVien(string ten, string phai, DateTime birth, string Socmnd, string Sodt, string Diachi)
        {
            ThemDB(ten, phai, birth, Socmnd, Sodt, Diachi);
        }
        
        private bool DocThongTin(string ten, string Socmnd)
        {
            cKetNoiDB.Con.Open();
            string sql = "select * from HocVien where CMND = '" + Socmnd + "'";
            SqlCommand cmd = new SqlCommand(sql, cKetNoiDB.Con);
            SqlDataReader reader = cmd.ExecuteReader();

            bool kq;

            if (reader.Read() != true)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            cKetNoiDB.Con.Close();
            return kq;
        }

        private void ThemDB(string ten, string phai, DateTime birth, string Socmnd, string Sodt, string Diachi)
        {
            cKetNoiDB.Con.Open();
            string sql = "Insert into HocVien values ('" + ten + "','" + Socmnd + "','"
                + Diachi + "','" + birth + "','" + phai + "','" + Sodt + "')";

            cKetNoiDB.RunSQL(sql);
            MessageBox.Show("Ghi nhận học viên thành công.");
            cKetNoiDB.Con.Close();
        }
    }
}
