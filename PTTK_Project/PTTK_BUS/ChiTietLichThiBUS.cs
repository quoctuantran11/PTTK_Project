using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;
using PTTK_DTO;

namespace PTTK_BUS
{
    public class ChiTietLichThiBUS
    {
        private static ChiTietLichThiBUS instance;

        public static ChiTietLichThiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietLichThiBUS();
                }

                return instance;
            }
        }

        private ChiTietLichThiBUS() { }

        public DataTable HienThiCombo()
        {
            return ChiTietLichThiDAO.Instance.HienThiCombo();
        }

        public void GhiNhan(string madotthi, string tenchungchi, string tenthisinh)
        {
            ChiTietLichThiDAO.Instance.GhiNhan(madotthi, tenchungchi, tenthisinh);
        }
    }
}
