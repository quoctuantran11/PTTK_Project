using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class GhiNhanHDDKCCQTBUS
    {
        private static GhiNhanHDDKCCQTBUS instance;

        public static GhiNhanHDDKCCQTBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GhiNhanHDDKCCQTBUS();
                return instance;
            }
        }

        private GhiNhanHDDKCCQTBUS() { }

        public bool KiemTraHocVien(string mathisinh)
        {
            if (GhiNhanHDDKCCQTDAO.Instance.KiemTra(mathisinh))
                return true;
            return false;
        }

        public bool GhiNhan(string ngaylap, int giamgia, int tongtien, int mathisinh)
        {
            return GhiNhanHDDKCCQTDAO.Instance.GhiDuLieu(ngaylap, giamgia, tongtien, mathisinh);
        }

    }
}
