using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class HoaDonDKHPBUS
    {
        private static HoaDonDKHPBUS instance;

        public static HoaDonDKHPBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDKHPBUS();
                return instance;
            }
        }

        private HoaDonDKHPBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = HoaDonDKHPDAO.Instance.XemDuLieu();
        }

        public void TimKiem(DataGridView data, string mahocvien)
        {
            data.DataSource = HoaDonDKHPDAO.Instance.TimKiemDuLieu(mahocvien);
        }

    }
}
