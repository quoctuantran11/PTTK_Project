using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class ChungChiNgoaiTrungTam_HocVienDAO
    {
        private static ChungChiNgoaiTrungTam_HocVienDAO instance;

        public static ChungChiNgoaiTrungTam_HocVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiNgoaiTrungTam_HocVienDAO();
                }

                return instance;
            }
        }

        private ChungChiNgoaiTrungTam_HocVienDAO() { }

        public void GhiHoSo(string ten, string machungchi)
        {
            string sql, mahocvien;

            DataProvider.Con.Open();

            sql = "Select MaHocVien from HocVien where HoTen = '" + ten + "'";
            mahocvien = DataProvider.GetFieldValues(sql);

            sql = "Insert into ChungChiNgoaiTrungTam_HocVien values (" + machungchi + "," + mahocvien + ")";

            DataProvider.RunSQL(sql);

            DataProvider.Con.Close();
        }
    }
}
