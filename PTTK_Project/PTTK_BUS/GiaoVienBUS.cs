using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiaoVienBUS();
                }

                return instance;
            }
        }

        private GiaoVienBUS() { }

        public void HienToanBo(DataGridView data)
        {
            data.DataSource = GiaoVienDAO.Instance.HienToanBo();
        }

        public bool TimGiaoVien(DataGridView data, string ten)
        {
            data.DataSource = GiaoVienDAO.Instance.TimGiaoVien(ten);

            if (data.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ThemGiaoVien(string ten, string diachi, DateTime ngaysinh, string phai, string sdt)
        {
            GiaoVienDAO.Instance.ThemGiaoVien(ten, diachi, ngaysinh, phai, sdt);
        }
    }
}
