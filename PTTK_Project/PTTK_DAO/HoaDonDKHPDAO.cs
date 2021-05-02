using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class HoaDonDKHPDAO
    {
        private static HoaDonDKHPDAO instance;

        public static HoaDonDKHPDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDKHPDAO();
                return instance;
            }
        }

        private HoaDonDKHPDAO() { }

        public DataTable XemDuLieu()
        {
            string query = "select * from HoaDonHocPhan";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public object TimKiemDuLieu(string mahocvien)
        {
            string query = "select * from HoaDonHocPhan where MaHocVien = " + mahocvien;
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }
    }
}
