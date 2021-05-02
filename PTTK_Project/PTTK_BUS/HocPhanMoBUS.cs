using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTTK_DAO;

namespace PTTK_BUS
{
    public class HocPhanMoBUS
    {
        private static HocPhanMoBUS instance;

        public static HocPhanMoBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanMoBUS();
                }

                return instance;
            }
        }

        private HocPhanMoBUS() { }

        public DataTable HienThiHocPhan()
        {
            return HocPhanMoDAO.Instance.LayHocPhan();
        }
        
        public string HienThiLoaiHocPhan(string tenhocphan)
        {
            return HocPhanMoDAO.Instance.LayLoaiHocPhan(tenhocphan);
        }
    }
}
