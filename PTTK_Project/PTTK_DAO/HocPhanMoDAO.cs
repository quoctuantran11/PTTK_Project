using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "Select HPM.MaHocPhan, HP.TenHocPhan from HocPhan HP join HocPhanMo HPM on " +
                "HP.MaHocPhan = HPM.MaHocPhan";

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
    }
}
