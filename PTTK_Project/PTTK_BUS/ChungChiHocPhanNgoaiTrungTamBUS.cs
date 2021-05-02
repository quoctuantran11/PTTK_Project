using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class ChungChiHocPhanNgoaiTrungTamBUS
    {
        private static ChungChiHocPhanNgoaiTrungTamBUS instance;

        public static ChungChiHocPhanNgoaiTrungTamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiHocPhanNgoaiTrungTamBUS();
                }

                return instance;
            }
        }

        private ChungChiHocPhanNgoaiTrungTamBUS() { }

        public bool KiemTraDuLieu(string machungchi, string noicap)
        {
            return ChungChiHocPhanNgoaiTrungTamDAO.Instance.KiemTraDuLieu(machungchi, noicap);
        }
    }
}
