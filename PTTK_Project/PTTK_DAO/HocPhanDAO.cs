using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance;

        public static HocPhanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanDAO();
                }

                return instance;
            }
        }

        private HocPhanDAO() { }

        public DataTable LayHocPhan()
        {
            string query = "select distinct MaHocPhan from HocPhan";
            DataProvider.Connect();
            DataTable table = new DataTable();
            table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }

        public DataTable XemToanBo()
        {
            string query = "select * from HocPhan";
            DataProvider.Connect();
            DataTable table = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return table;
        }
    }
}

