using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class ChungChiQuocTeBUS
    {
        private static ChungChiQuocTeBUS instance;

        public static ChungChiQuocTeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChungChiQuocTeBUS();
                }

                return instance;
            }
        }

        private ChungChiQuocTeBUS() { }

        public DataTable HienThiChungChi()
        {
            return ChungChiQuocTeDAO.Instance.LayTenChungChi();
        }
    }
}
