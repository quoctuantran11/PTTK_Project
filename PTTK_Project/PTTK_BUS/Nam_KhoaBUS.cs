using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class Nam_KhoaBUS
    {
        private static Nam_KhoaBUS instance;

        public static Nam_KhoaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Nam_KhoaBUS();
                }

                return instance;
            }
        }

        private Nam_KhoaBUS() { }

        public DataTable HienThiNam()
        {
            return Nam_KhoaDAO.Instance.LayNam();
        }

        public DataTable HienThiKhoa()
        {
            return Nam_KhoaDAO.Instance.LayKhoa();
        }
    }
}
