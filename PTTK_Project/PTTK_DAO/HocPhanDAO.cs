using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance;

        public static HocPhanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HocPhanDAO();
                }

                return instance;
            }
        }

        private HocPhanDAO() { }


    }
}

