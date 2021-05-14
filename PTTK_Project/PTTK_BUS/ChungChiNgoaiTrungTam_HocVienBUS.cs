using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class ChungChiNgoaiTrungTam_HocVienBUS
    {
        private static ChungChiNgoaiTrungTam_HocVienBUS instance;

        public static ChungChiNgoaiTrungTam_HocVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiNgoaiTrungTam_HocVienBUS();
                }

                return instance;
            }
        }

        private ChungChiNgoaiTrungTam_HocVienBUS() { }

        public bool GhiHoSo(string ten, string machungchi)
        {
            return ChungChiNgoaiTrungTam_HocVienDAO.Instance.GhiHoSo(ten, machungchi);
        }
    }
}
