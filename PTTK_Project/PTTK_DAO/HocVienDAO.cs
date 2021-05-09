using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;

namespace PTTK_DAO
{
    public class HocVienDAO
    {
        private static HocVienDAO instance;

        public static HocVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocVienDAO();
                }

                return instance;
            }
        }

        private HocVienDAO() { }

        public DataTable KiemTraTrungLap(string cmnd)
        {
            DataProvider.Con.Open();
            string sql = "select * from HocVien where CMND = " + cmnd;

            DataTable data = DataProvider.GetDataToTable(sql);

            DataProvider.Con.Close();

            return data;
        }

        public bool ThemHocVien(string hoten, string gioitinh, string ngaysinh, string cmnd, string sdt, string diachi)
        {
            DataProvider.Con.Open();
            string sql = "Insert into HocVien values ('" + hoten + "','" + cmnd + "','"
                + diachi + "','" + ngaysinh + "','" + gioitinh + "','" + sdt + "')";

            try
            {
                DataProvider.RunSQL(sql);
                DataProvider.Con.Close();
                return true;
            }
            catch
            {
                DataProvider.Con.Close();
                return false;
            }
            
       
            
        }
    }
}
