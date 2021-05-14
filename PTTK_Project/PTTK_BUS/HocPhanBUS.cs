using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class HocPhanBUS
    {
        private static HocPhanBUS instance;

        public static HocPhanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanBUS();
                }

                return instance;
            }
        }

        private HocPhanBUS() { }

        public DataTable HienThiHocPhan()
        {
            return HocPhanDAO.Instance.LayHocPhan();
        }

        public void XemToanBo(DataGridView data)
        {
            data.DataSource = HocPhanDAO.Instance.XemToanBo();
        }

        public bool GhiHocPhan(string ten, string loai)
        {
            return HocPhanDAO.Instance.ThemHocPhan(ten, loai);
        }

        public bool XoaHocPhan(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string ma = row.Cells["MaHocPhan"].Value.ToString();
            string loai = row.Cells["LoaiHocPhan"].Value.ToString();
            string ten = row.Cells["TenHocPhan"].Value.ToString();

            return HocPhanDAO.Instance.XoaHocPhan(ma, ten, loai);
        }
    }
}
