using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class LichThiBUS
    {
        private static LichThiBUS instance;

        public static LichThiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichThiBUS();
                }

                return instance;
            }
        }

        private LichThiBUS() { }

        public void Xem(DataGridView data)
        {
            data.DataSource = LichThiDAO.Instance.Xem();
        }

        public void Xem_ChungChi(DataGridView data, string tenchungchi)
        {
            data.DataSource = LichThiDAO.Instance.Xem_ChungChi(tenchungchi);
        }

        public void Xem_DiaDiem(DataGridView data, string tendiadiem)
        {
            data.DataSource = LichThiDAO.Instance.Xem_DiaDiem(tendiadiem);
        }

        public void Xem_DiaDiemvaChungChi(DataGridView data, string tenchungchi, string tendiadiem)
        {
            data.DataSource = LichThiDAO.Instance.Xem_DiaDiemvaChungChi(tendiadiem, tenchungchi);
        }
    }
}
