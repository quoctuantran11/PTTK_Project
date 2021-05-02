using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;

namespace PTTK_DAO
{
    public class ChiTietLichThiDAO
    {
        private static ChiTietLichThiDAO instance;

        public static ChiTietLichThiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietLichThiDAO();
                }

                return instance;
            }
        }

        private ChiTietLichThiDAO() { }

        public DataTable HienThiCombo()
        {
            DataProvider.Con.Open();

            string query = "select MaSoDotThi from DotThi";

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public void GhiNhan(string madotthi, string tenchungchi, string tenthisinh)
        {
            DataProvider.Con.Open();

            string query = "select MaChungChi from ChungChiQuocTe where TenChungChi = '" + tenchungchi + "'";

            string machungchi = DataProvider.GetFieldValues(query);

            query = "select MaThiSinh from NguoiThamDuThi where HoTen = '" + tenthisinh + "'";

            string mathisinh = DataProvider.GetFieldValues(query);

            query = "insert into ChiTietLichThi values (" + madotthi + "," + machungchi + "," + mathisinh + ")";

            DataProvider.RunSQL(query);

            DataProvider.Con.Close();
        }
    }
}
