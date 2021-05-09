using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PTTK_DAO
{
    public class HocPhanMoDAO
    {
        private static HocPhanMoDAO instance;

        public static HocPhanMoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanMoDAO();
                }

                return instance;
            }
        }

        private HocPhanMoDAO() { }
        
        public DataTable LayHocPhan()
        {
            DataProvider.Con.Open();
            string sql = "Select HPM.MaHocPhan, HP.TenHocPhan, HPM.Nam, HPM.Khoa from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan";

            DataTable data = DataProvider.GetDataToTable(sql);

            DataProvider.Con.Close();

            return data;
        }

        public DataTable LayHocPhanMo(string nam, string khoa)
        {
            DataProvider.Con.Open();
            string sql = "Select HPM.MaHocPhan, HP.TenHocPhan, HPM.Nam, HPM.Khoa from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan where HPM.Nam = " + nam + " and HPM.Khoa = " + khoa;

            DataTable data = DataProvider.GetDataToTable(sql);

            DataProvider.Con.Close();

            return data;
        }

        public string LayLoaiHocPhan(string tenhocphan)
        {
            DataProvider.Con.Open();

            string sql = "select LoaiHocPhan from HocPhan where TenHocPhan = '" + tenhocphan + "'";
            string loaihocphan = DataProvider.GetFieldValues(sql);

            DataProvider.Con.Close();

            return loaihocphan;
        }

        public DataTable LayDanhSachHocPhanMo()
        {
            string query = "Select HPM.MaHocPhan, HP.TenHocPhan, HPM.Nam, HPM.Khoa, HPM.PhongHoc, HPM.SoLuongSV, HPM.MaGV, GV.HoTenGV from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan join GiaoVien GV on HPM.MaGV = GV.MaGiaoVien";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public DataTable LayDanhSachHocMo2(int mahocphan, int nam, int khoa)
        {
            string query = "Select HPM.MaHocPhan, HP.TenHocPhan, HPM.Nam, HPM.Khoa, HPM.PhongHoc, HPM.SoLuongSV, HPM.MaGV, GV.HoTenGV from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan join GiaoVien GV on HPM.MaGV = GV.MaGiaoVien" +
                " where HPM.MaHocPhan = " + mahocphan + " and HPM.Nam =" +nam+ " and HPM.Khoa =" + khoa;
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public bool ThemHocPhanMo(int mahocphan, int nam, int khoa, string phonghoc, int soluongsv, int magv)
        {

            string query = "insert into HocPhanMo values (" +mahocphan+ "," +nam+ "," +khoa+ ", '" +phonghoc+ "' ," +soluongsv+ "," +magv+ ")";

            DataProvider.Connect();
            SqlCommand command = new SqlCommand(query, DataProvider.Con);
            if (command.ExecuteNonQuery() > 0)
            {
                DataProvider.Disconnect();
                return true;
            }

            DataProvider.Disconnect();
            return false;
        }

        public bool XoaHocPhanMo(string mahocphan, string nam, string khoa)
        {
            DataProvider.Connect();

            string query = "Delete from HocPhanMo where MaHocPhan = " + mahocphan + " and Nam = " +nam + " and Khoa = " + khoa;

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

        public bool SuaHocPhanMo(int mahocphan, int nam, int khoa, string phonghoc, int soluongsv, int magv)
        {

            string query = "update HocPhanMo set  PhongHoc = '" +phonghoc+ "', SoLuongSV = " +soluongsv+ ", MaGV = " +magv+
                "where MaHocPhan = " +mahocphan+ " and Nam = " +nam+ " and Khoa = " +khoa;

            DataProvider.Connect();
            SqlCommand command = new SqlCommand(query, DataProvider.Con);
            if (command.ExecuteNonQuery() > 0)
            {
                DataProvider.Disconnect();
                return true;
            }

            DataProvider.Disconnect();
            return false;
        }
    }
}
