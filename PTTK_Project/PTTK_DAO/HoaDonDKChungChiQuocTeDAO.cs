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
    public class HoaDonDKChungChiQuocTeDAO
    {
        private static HoaDonDKChungChiQuocTeDAO instance;

        public  static HoaDonDKChungChiQuocTeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDKChungChiQuocTeDAO();
                return instance;
            }
        }

        private HoaDonDKChungChiQuocTeDAO() { }

        public DataTable XemDuLieu()
        {
            string query = "select * from HoaDonDKChungChiQuocTe";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public DataTable TimKiemDuLieu(string mathisinh)
        {
            string query = "select * from HoaDonDKChungChiQuocTe where MaThiSinh = " + mathisinh;
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }
    }
}
