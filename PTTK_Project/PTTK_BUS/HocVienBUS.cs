using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;
using PTTK_DTO;

namespace PTTK_BUS
{
    public class HocVienBUS
    {
        private static HocVienBUS instance;

        public static HocVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocVienBUS();
                }

                return instance;
            }
        }

        private HocVienBUS() { }

        public bool ThemHocVien(string hoten, string gioitinh, string ngaysinh, string cmnd, string sdt, string diachi)
        {
            return HocVienDAO.Instance.ThemHocVien(hoten, gioitinh, ngaysinh, cmnd, sdt, diachi);
        }

        public bool KiemTraTrungLap(string cmnd)
        {
            DataTable data = HocVienDAO.Instance.KiemTraTrungLap(cmnd);

            if (data.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
