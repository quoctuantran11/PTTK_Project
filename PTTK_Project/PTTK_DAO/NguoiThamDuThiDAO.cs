using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;

namespace PTTK_DAO
{
    public class NguoiThamDuThiDAO
    {

        private static NguoiThamDuThiDAO instance;

        public static NguoiThamDuThiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NguoiThamDuThiDAO();
                }

                return instance;
            }
        }

        private NguoiThamDuThiDAO() { }

        public void GhiNhan(string hoten, string gioitinh, string ngaysinh, string cmnd, string sdt, string diachi)
        {
            DataProvider.Con.Open();
            string sql = "Insert into NguoiThamDuThi values ('" + hoten + "','" + cmnd + "','"
                + diachi + "','" + ngaysinh + "','" + gioitinh + "','" + sdt + "')";

            DataProvider.RunSQL(sql);

            DataProvider.Con.Close();
        }
    }
}
