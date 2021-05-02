using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;
using System.Data.SqlClient;


namespace PTTK_DAO
{
    public class KetQuaThiLaiDAO
    {
        private static KetQuaThiLaiDAO instance;

        public static KetQuaThiLaiDAO Instance
        {
            get
            {
                if(instance ==null)
                {
                    instance = new KetQuaThiLaiDAO();
                }

                return instance;
            }
        }

        private KetQuaThiLaiDAO() { }

        public List<KetQuaThiLai> HienThiToanBo()
        {
            List<KetQuaThiLai> ketquathilai = new List<KetQuaThiLai>();

            string query = "select * from KetQuaThiLai";
            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            foreach(DataRow item in data.Rows)
            {
                string maHocVien = item["MaHocVien"].ToString();
                string maHocPhan = item["MaHocPhan"].ToString();
                string nam = item["Nam"].ToString();
                string khoa = item["Khoa"].ToString();
                DateTime Ngaythilai = (DateTime)item["NgayThiLai"];
                string diem = item["Diem"].ToString();
                string Solanthilai = item["SoLanDaThiLai"].ToString();

                KetQuaThiLai newKqtl = new KetQuaThiLai(maHocPhan, nam, khoa, maHocVien, Ngaythilai, diem, Solanthilai);

                ketquathilai.Add(newKqtl);
            }

            DataProvider.Con.Close();
            return ketquathilai;
        }

        public DataTable HienThiComboNam(string monhoc, string cmnd)
        {
            string query = "select MaHocVien from HocVien where CMND = " + cmnd;

            DataProvider.Con.Open();
            string maHocVien = DataProvider.GetFieldValues(query);
            if(maHocVien == "")
            {
                maHocVien = "0";
            }

            query = "select MaHocPhan from HocPhan where TenHocPhan = '" + monhoc + "'";

            string maHocPhan = DataProvider.GetFieldValues(query);
            if (maHocPhan == "")
            {
                maHocPhan = "0";
            }

            query = "select Nam from KetQuaDangKyHocPhan where MaHocPhan = " + maHocPhan + " and " +
                "MaHocVien = " + maHocVien;

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienThiComboKhoa(string monhoc, string cmnd)
        {
            string query = "select MaHocVien from HocVien where CMND = " + cmnd;

            DataProvider.Con.Open();
            string maHocVien = DataProvider.GetFieldValues(query);
            if (maHocVien == "")
            {
                maHocVien = "0";
            }

            query = "select MaHocPhan from HocPhan where TenHocPhan = '" + monhoc + "'";

            string maHocPhan = DataProvider.GetFieldValues(query);
            if (maHocPhan == "")
            {
                maHocPhan = "0";
            }

            query = "select Khoa from KetQuaDangKyHocPhan where MaHocPhan = " + maHocPhan + " and " +
                "MaHocVien = " + maHocVien;

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public void NhapDiem(string tenHocPhan, string nam, string khoa, string tenHocVien, string cmnd, string diem, DateTime ngaythilai)
        {
            string query = "select MaHocVien from HocVien where HoTen = '" + tenHocVien + "' and " +
                "CMND = " + cmnd;

            DataProvider.Con.Open();
            string maHocVien = DataProvider.GetFieldValues(query);

            query = "select MaHocPhan from HocPhan where TenHocPhan = '" + tenHocPhan + "'";

            string maHocPhan = DataProvider.GetFieldValues(query);

            query = "Insert into KetQuaThiLai values (" + maHocPhan + "," + nam + "," + khoa + "," +
                maHocVien + "," + diem + ",'" + ngaythilai + "',1)";

            SqlCommand cmd = new SqlCommand(query, DataProvider.Con);
            try
            {
                cmd.ExecuteNonQuery();
                DataProvider.Con.Close();
            }
            catch (Exception ex)
            {
                DataProvider.Con.Close();
            }
        }

        public bool Xoa(string maHocPhan, string nam, string khoa, string maHocVien, KetQuaThiLai kqtl)
        {
            DataProvider.Con.Open();

            string query = "Delete from KetQuaThiLai where MaHocPhan = " + maHocPhan + " and Nam = " +
                nam + " and Khoa = " + khoa + " and MaHocVien = " + maHocVien;

            SqlCommand cmd = new SqlCommand(query, DataProvider.Con);
            try
            {
                cmd.ExecuteNonQuery();
                DataProvider.Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.Con.Close();
                return false;
            }

        }

        public void HienThi_Sua(string maHocPhan, string nam, string khoa, string maHocVien)
        {
            
        }

        public void SuaDiem()
        {

        }    

        public List<KetQuaThiLai> TimKiem(string ten)
        {
            List<KetQuaThiLai> ketquathilai = new List<KetQuaThiLai>();

            string query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
            DataProvider.Con.Open();

            string maHocVien = DataProvider.GetFieldValues(query);

            query = "Select * from KetQuaThiLai where MaHocVien = " + maHocVien;

            DataTable data = DataProvider.GetDataToTable(query);

            foreach (DataRow item in data.Rows)
            {
                string maHocPhan = item["MaHocPhan"].ToString();
                string nam = item["Nam"].ToString();
                string khoa = item["Khoa"].ToString();
                DateTime Ngaythilai = (DateTime)item["NgayThiLai"];
                string diem = item["Diem"].ToString();
                string Solanthilai = item["SoLanDaThiLai"].ToString();

                KetQuaThiLai newKqtl = new KetQuaThiLai(maHocPhan, nam, khoa, maHocVien, Ngaythilai, diem, Solanthilai);

                ketquathilai.Add(newKqtl);
            }

            DataProvider.Con.Close();
            return ketquathilai;
        }
    }
}
