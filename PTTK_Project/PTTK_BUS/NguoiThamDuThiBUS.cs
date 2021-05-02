using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DTO;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class NguoiThamDuThiBUS
    {
        private static NguoiThamDuThiBUS instance;

        public static NguoiThamDuThiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NguoiThamDuThiBUS();
                }

                return instance;
            }
        }

        private NguoiThamDuThiBUS() { }

        public void GhiNhan(string hoten, string gioitinh, DateTime ngaysinh, string cmnd, string sdt, string diachi)
        {
            NguoiThamDuThiDAO.Instance.GhiNhan(hoten, gioitinh, ngaysinh, cmnd, sdt, diachi);
        }

    }
}
