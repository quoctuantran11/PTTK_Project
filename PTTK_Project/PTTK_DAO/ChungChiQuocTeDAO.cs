using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class ChungChiQuocTeDAO
    {
        private static ChungChiQuocTeDAO instance;

        public static ChungChiQuocTeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiQuocTeDAO();
                }

                return instance;
            }
        }

        private ChungChiQuocTeDAO() { }

        public DataTable LayTenChungChi()
        {
            string query = "select TenChungChi from ChungChiQuocTe";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }
    }
}
