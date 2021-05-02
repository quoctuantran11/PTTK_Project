using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable TimKiem(string ten)
        {
            string query = "select MaHocVien from HocVien where HoTen = '" + ten + "'";
            DataProvider.Con.Open();

            string maHocVien = DataProvider.GetFieldValues(query);

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
            string siso = DataProvider.GetFieldValues(sql);

            DataProvider.Con.Close();
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
    }
}
