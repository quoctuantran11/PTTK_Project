using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class ChungChiHocPhanNgoaiTrungTamDAO
    {
        private static ChungChiHocPhanNgoaiTrungTamDAO instance;

        public static ChungChiHocPhanNgoaiTrungTamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiHocPhanNgoaiTrungTamDAO();
                }

                return instance;
            }
        }

        private ChungChiHocPhanNgoaiTrungTamDAO() { }

        public bool KiemTraDuLieu(string machungchi, string noicap)
        {
            string sql = "select TenChungChi from ChungChiHocPhanTrungTam where MaChungChi = '" + machungchi + "'" +
                    " and NoiCap = '" + noicap + "'";

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
