using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiaoVienDAO();
                }

                return instance;
            }
        }

        private GiaoVienDAO() { }

        public DataTable HienToanBo()
        {
            string query = "Select * from GiaoVien";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public DataTable TimGiaoVien(string ten)
        {
            string query = "Select * from GiaoVien where HoTenGV = '" + ten + "'";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();
            return data;
        }

        public void ThemGiaoVien(string ten, string diachi, string ngaysinh, string phai, string sdt)
        {
            string query = "insert into GiaoVien values ('" + ten + "','" + diachi + "','" + ngaysinh +
                "','" + phai + "','" + sdt + "')";

            DataProvider.Con.Open();

            DataProvider.RunSQL(query);

            DataProvider.Con.Close();
        }

        public DataTable LayMaGV()
        {
            string query = "Select MaGiaoVien from GiaoVien";

            DataProvider.Connect();
            DataTable data = DataProvider.GetDataToTable(query);
            DataProvider.Disconnect();
            return data;
        }
    }
}
