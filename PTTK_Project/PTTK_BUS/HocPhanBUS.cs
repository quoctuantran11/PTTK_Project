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
    }
}
