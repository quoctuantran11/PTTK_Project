using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class HoaDonDKChungChiQuocTe
    {
        private static HoaDonDKChungChiQuocTe instance;

        public static HoaDonDKChungChiQuocTe Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDKChungChiQuocTe();
                return instance;
            }
        }

        private HoaDonDKChungChiQuocTe() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = HoaDonDKChungChiQuocTeDAO.Instance.XemDuLieu();
        }

        public void TimKiem(DataGridView data, string mathisinh)
        {
            data.DataSource = HoaDonDKChungChiQuocTeDAO.Instance.TimKiemDuLieu(mathisinh);
        }
    }
}
