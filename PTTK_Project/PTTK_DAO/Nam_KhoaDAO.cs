using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class Nam_KhoaDAO
    {
        private static Nam_KhoaDAO instance;

        public static Nam_KhoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Nam_KhoaDAO();
                return instance;
            }
        }

        private Nam_KhoaDAO() { }

        public DataTable LayNam()
        {
            string query = "select distinct Nam from Nam_Khoa";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public DataTable LayKhoa()
        {
            string query = "select distinct Khoa, Khoa from Nam_Khoa";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }
    }
}
