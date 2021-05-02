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
    public class GhiNhanHDDKCCQTDAO
    {
        private static GhiNhanHDDKCCQTDAO instance;

        public static GhiNhanHDDKCCQTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GhiNhanHDDKCCQTDAO();
                return instance;
            }
        }

        private GhiNhanHDDKCCQTDAO() { }

        public bool KiemTra(string mathisinh)
        {
            string query = "select * from NguoiThamDuThi where MaThiSinh = " + mathisinh;
            string cmnd = "";
            DataProvider.Connect();
            if(DataProvider.CheckKey(query) == false)
            {
                DataProvider.Disconnect();
                return false;
            }
            else
            {
                SqlCommand command = new SqlCommand(query, DataProvider.Con);
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    cmnd = (string)data["CMND"];
                }
                DataProvider.Disconnect();

                string query1 = "select * from HocVien where CMND = '" + cmnd + "'";
                DataProvider.Connect();
                SqlCommand command1 = new SqlCommand(query1, DataProvider.Con);
                SqlDataReader data1 = command1.ExecuteReader();
                if (data1.Read())
                {
                    DataProvider.Disconnect();
                    return true;
                }    
                else
                {
                    DataProvider.Disconnect();
                    return false;
                }
            }
        }

        public bool GhiDuLieu(DateTime ngaylap, int giamgia, int tongtien, int mathisinh)
        {
            string query = "insert into HoaDonDKChungChiQuocTe (NgayLap, GiamGia, TongTien, MaThiSinh) values ('" + ngaylap + "'," + giamgia + "," + tongtien + "," + mathisinh + ")";
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
