using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
