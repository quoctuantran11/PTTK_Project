using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class GhiNhanHDDKHPBUS
    {
        private static GhiNhanHDDKHPBUS instance;

        public static GhiNhanHDDKHPBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GhiNhanHDDKHPBUS();
                return instance;
            }
        }

        private GhiNhanHDDKHPBUS() { }

        public bool GhiNhan(DateTime ngaylap, int tongtien, int mahocvien)
        {
            return GhiNhanHDDKHPDAO.Instance.GhiDuLieu(ngaylap, tongtien, mahocvien);
        }
    }
}
