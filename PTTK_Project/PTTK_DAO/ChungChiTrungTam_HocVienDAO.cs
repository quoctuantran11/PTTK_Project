using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class ChungChiTrungTam_HocVienDAO
    {
        private static ChungChiTrungTam_HocVienDAO instance;

        public static ChungChiTrungTam_HocVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiTrungTam_HocVienDAO();
                }

                return instance;
            }
        }

        private ChungChiTrungTam_HocVienDAO() { }

        public void GhiHoSo(string ten, string machungchi)
        {
            string sql, mahocvien;

            DataProvider.Con.Open();

            sql = "Select MaHocVien from HocVien where HoTen = '" + ten + "'";
            mahocvien = DataProvider.GetFieldValues(sql);

            sql = "Insert into ChungChiTrungTam_HocVien values (" + machungchi + "," + mahocvien + ")";

            DataProvider.RunSQL(sql);
            
            DataProvider.Con.Close();
        }
    }
}
