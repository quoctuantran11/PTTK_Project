using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class ChungChiTrungTam_HocVienBUS
    {
        private static ChungChiTrungTam_HocVienBUS instance;

        public static ChungChiTrungTam_HocVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiTrungTam_HocVienBUS();
                }

                return instance;
            }
        }

        private ChungChiTrungTam_HocVienBUS() { }

        public void GhiHoSo(string ten, string machungchi)
        {
            ChungChiTrungTam_HocVienDAO.Instance.GhiHoSo(ten, machungchi);
        }
    }
}
