using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class DotThiBUS
    {
        private static DotThiBUS instance;

        public static DotThiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DotThiBUS();
                }

                return instance;
            }
        }

        private DotThiBUS() { }

        public DataTable HienThiDiaDiemThi()
        {
            return DotThiDAO.Instance.LayDiaDiemThi();
        }
    }
}
