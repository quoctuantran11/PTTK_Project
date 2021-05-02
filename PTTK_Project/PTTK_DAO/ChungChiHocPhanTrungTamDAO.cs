using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class ChungChiHocPhanTrungTamDAO
    {
        private static ChungChiHocPhanTrungTamDAO instance;

        public static ChungChiHocPhanTrungTamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiHocPhanTrungTamDAO();
                }

                return instance;
            }
        }

        private ChungChiHocPhanTrungTamDAO() { }

        public bool KiemTraDuLieu(string machungchi)
        {
            string sql = "select TenChungChi from ChungChiHocPhanTrungTam where MaChungChi = '" + machungchi + "'";

            DataProvider.Con.Open();

            if (DataProvider.GetFieldValues(sql) != "")
            {
                DataProvider.Con.Close();
                return true;
            }
            else
            {
                DataProvider.Con.Close();
                return false;
            }
        }
    }
}
