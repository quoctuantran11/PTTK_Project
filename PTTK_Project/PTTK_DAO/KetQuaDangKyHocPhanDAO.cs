using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;

namespace PTTK_DAO
{
    public class KetQuaDangKyHocPhanDAO
    {
        private static KetQuaDangKyHocPhanDAO instance;

        public static KetQuaDangKyHocPhanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaDangKyHocPhanDAO();
                }

                return instance;
            }
        }

        private KetQuaDangKyHocPhanDAO() { }

        public DataTable HienToanBo()
        {
            DataProvider.Con.Open();

            string query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienTheoNam(string ten, string nam)
        {
            DataProvider.Con.Open();
            string query = "";

            if (ten == "")
            {
                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien where KQHP.Nam = " + nam;
            }
            else
            {
                query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
                string maHocVien = DataProvider.GetFieldValues(query);

                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                " where KQHP.MaHocVien = " + maHocVien + " and KQHP.Nam = " + nam;
            }

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienTheoKhoa(string ten, string khoa)
        {
            DataProvider.Con.Open();
            string query = "";

            if (ten == "")
            {
                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien where KQHP.Khoa = " + khoa;
            }
            else
            {
                query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
                string maHocVien = DataProvider.GetFieldValues(query);

                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                " where KQHP.MaHocVien = " + maHocVien + " and KQHP.Khoa = " + khoa;
            }

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienTheoNamvaKhoa(string ten, string nam, string khoa)
        {
            DataProvider.Con.Open();
            string query = "";

            if (ten == "")
            {
                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien where KQHP.Nam = " + nam +
                    " and KQHP.Khoa = " + khoa;
            }
            else
            {
                query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
                string maHocVien = DataProvider.GetFieldValues(query);

                query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                " where KQHP.MaHocVien = " + maHocVien + " and KQHP.Nam = " + nam +
                    " and KQHP.Khoa = " + khoa;
            }

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienNam()
        {
            DataProvider.Con.Open();

            string query = "Select distinct Nam from KetQuaDangKyHocPhan";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable HienKhoa()
        {
            DataProvider.Con.Open();

            string query = "Select distinct Khoa from KetQuaDangKyHocPhan";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
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

            query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,HV.HoTen,KQHP.Diem,KQHP.NgayCap" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                " where KQHP.MaHocVien = " + maHocVien;

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public bool DangKyHP(string ten, string nam, string khoa, string hocphan)
        {
            DataProvider.Con.Open();
            string mahocphan, mahocvien;

            string sql = "Select MaHocPhan from HocPhan where TenHocPhan = '" + hocphan + "'";
            mahocphan = DataProvider.GetFieldValues(sql);

            sql = "Select MaHocvien from HocVien where HoTen = '" + ten + "'";
            mahocvien = DataProvider.GetFieldValues(sql);

            sql = "Insert into KetQuaDangKyHocPhan values (" + mahocphan + "," + nam + ","
                + khoa + "," + mahocvien + ")";

            try
            {
                DataProvider.RunSQL(sql);
                DataProvider.Con.Close();
                return true;
            }
            catch 
            {
                DataProvider.Con.Close();
                return false;
            }
            
        }

        public string LaySiSoToiDa(string nam, string khoa, string hocphan)
        {
            DataProvider.Con.Open();
            string mahocphan;

            string sql = "Select MaHocPhan from HocPhan where TenHocPhan = '" + hocphan + "'";
            mahocphan = DataProvider.GetFieldValues(sql);

            sql = "Select SoLuongSV from HocPhanMo where MaHocPhan = " + mahocphan + " and " +
                "Nam = " + nam + " and Khoa = " + khoa;

            string siso = "";

            try
            {
                siso = DataProvider.GetFieldValues(sql);

                DataProvider.Con.Close();
            }
            catch
            {
                DataProvider.Con.Close();
            }

            return siso;
        }

        public string LaySLDangKy(string nam, string khoa, string hocphan)
        {
            DataProvider.Con.Open();
            string mahocphan;

            string sql = "Select MaHocPhan from HocPhan where TenHocPhan = '" + hocphan + "'";
            mahocphan = DataProvider.GetFieldValues(sql);

            sql = "Select count(*) from KetQuaDangKyHocPhan where MaHocPhan = " + mahocphan + " and " +
                "Nam = " + nam + " and Khoa = " + khoa;
            string sisodk = DataProvider.GetFieldValues(sql);

            DataProvider.Con.Close();
            return sisodk;
        }

        public bool XoaDKHP(string tenhocphan, string nam, string khoa, string tenhocvien)
        {
            DataProvider.Con.Open();

            string query = "select MaHocPhan from HocPhan where TenHocPhan = '" + tenhocphan + "'";
            string mahocphan = DataProvider.GetFieldValues(query);

            query = "select MaHocVien from HocVien where HoTen = '" + tenhocvien + "'";
            string mahocvien = DataProvider.GetFieldValues(query);

            query = "Delete from KetQuaDangKyHocPhan where MaHocPhan = " + mahocphan + " and Nam = " +
                nam + " and Khoa = " + khoa + " and MaHocVien = " + mahocvien;

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

        public DataTable DemHocVien()
        {
            DataProvider.Con.Open();

            string query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,count(KQHP.MaHocVien) SoLuongHocVien" +
                " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                " group by HP.TenHocPhan,KQHP.Nam,KQHP.Khoa";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable ThongKeTheoNam(string nam)
        {
            DataProvider.Con.Open();
            string query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,count(KQHP.MaHocVien) SoLuongHocVien" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                    " where KQHP.Nam = " + nam + " group by HP.TenHocPhan,KQHP.Nam,KQHP.Khoa";


            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable ThongKeTheoQuy(string khoa)
        {
            DataProvider.Con.Open();
            string query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,count(KQHP.MaHocVien) SoLuongHocVien" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien" +
                    " where KQHP.Khoa = " + khoa + " group by HP.TenHocPhan,KQHP.Nam,KQHP.Khoa";


            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable ThongKeTheoNamvaQuy(string nam, string khoa)
        {
            DataProvider.Con.Open();
            string query = "Select HP.TenHocPhan,KQHP.Nam,KQHP.Khoa,count(KQHP.MaHocVien) SoLuongHocVien" +
                    " from KetQuaDangKyHocPhan KQHP join HocPhan HP on KQHP.MaHocPhan = HP.MaHocPhan" +
                    " join HocVien HV on KQHP.MaHocVien = HV.MaHocVien where KQHP.Nam = " + nam +
                    " and KQHP.Khoa = " + khoa + " group by HP.TenHocPhan,KQHP.Nam,KQHP.Khoa";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }
    }
}
