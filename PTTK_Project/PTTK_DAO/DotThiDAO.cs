using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class DotThiDAO
    {
        private static DotThiDAO instance;

        public static DotThiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DotThiDAO();
                }

                return instance;
            }
        }

        private DotThiDAO() { }

        public DataTable LayDiaDiemThi()
        {
            string query = "select DiaDiem from DotThi";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }    
    }
}
