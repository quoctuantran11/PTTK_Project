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

        public DataTable HienThiToanBo()
        {
            string query = "select KQTL.MaHocPhan, HP.TenHocPhan, KQTL.Nam, KQTL.Khoa, HV.HoTen, KQTL.Diem, KQTL.NgayThiLai, KQTL.SoLanDaThiLai " +
                "from KetQuaThiLai KQTL join HocPhan HP on KQTL.MaHocPhan = HP.MaHocPhan " +
                "join HocVien HV on KQTL.MaHocVien = HV.MaHocVien";
            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
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

        public DataTable TimKiem(string ten)
        {
            string query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
            DataProvider.Con.Open();

            string maHocVien = DataProvider.GetFieldValues(query);

            if (maHocVien == "")
            {
                maHocVien = "0";
            }

            query = "select KQTL.MaHocPhan, HP.TenHocPhan, KQTL.Nam, KQTL.Khoa, HV.HoTen, KQTL.Diem, KQTL.NgayThiLai, KQTL.SoLanDaThiLai " +
                "from KetQuaThiLai KQTL join HocPhan HP on KQTL.MaHocPhan = HP.MaHocPhan " +
                "join HocVien HV on KQTL.MaHocVien = HV.MaHocVien where HV.MaHocVien = " + maHocVien;

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }
    }
}
