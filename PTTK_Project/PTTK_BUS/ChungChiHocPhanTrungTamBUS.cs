using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class ChungChiHocPhanTrungTamBUS
    {
        private static ChungChiHocPhanTrungTamBUS instance;

        public static ChungChiHocPhanTrungTamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiHocPhanTrungTamBUS();
                }

                return instance;
            }
        }

        private ChungChiHocPhanTrungTamBUS() { }

        public bool KiemTraDuLieu(string machungchi)
        {
            return ChungChiHocPhanTrungTamDAO.Instance.KiemTraDuLieu(machungchi);
        }
    }
}
