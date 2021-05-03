using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class GhiNhanHDDKHPDAO
    {
        private static GhiNhanHDDKHPDAO instance;

        public static GhiNhanHDDKHPDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GhiNhanHDDKHPDAO();
                return instance;
            }
        }

        private GhiNhanHDDKHPDAO() { }

        public bool GhiDuLieu(DateTime ngaylap, int tongtien, int mahocvien)
        {
            string query = "insert into HoaDonHocPhan (NgayLap, TongTien, MaHocVien) values ('" + ngaylap + "'," + tongtien + "," + mahocvien + ")";
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
