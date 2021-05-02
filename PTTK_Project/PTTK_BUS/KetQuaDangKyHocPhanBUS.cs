using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_DAO;
using PTTK_DTO;

namespace PTTK_BUS
{
    public class KetQuaDangKyHocPhanBUS
    {
        private static KetQuaDangKyHocPhanBUS instance;

        public static KetQuaDangKyHocPhanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaDangKyHocPhanBUS();
                }

                return instance;
            }
        }

        private KetQuaDangKyHocPhanBUS() { }

        public bool TimKiem(DataGridView data, string ten)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.TimKiem(ten);

            if (data.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DangKyHP(string ten, string nam, string khoa, string hocphan)
        {
            return KetQuaDangKyHocPhanDAO.Instance.DangKyHP(ten, nam, khoa, hocphan);
        }  
        
        public string LaySiSo(string nam, string khoa, string hocphan)
        {
            return KetQuaDangKyHocPhanDAO.Instance.LaySiSoToiDa(nam, khoa, hocphan);
        }

        public string LaySiSoDK(string nam, string khoa, string hocphan)
        {
            return KetQuaDangKyHocPhanDAO.Instance.LaySLDangKy(nam, khoa, hocphan);
        }
    }
}
