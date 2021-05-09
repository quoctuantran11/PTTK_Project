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

        public DataTable HienThiHocPhanMo(string nam, string khoa)
        {
            return HocPhanMoDAO.Instance.LayHocPhanMo(nam,khoa);
        }

        public string HienThiLoaiHocPhan(string tenhocphan)
        {
            return HocPhanMoDAO.Instance.LayLoaiHocPhan(tenhocphan);
        }

        public void HienThiDanhSachHocPhanMo(DataGridView data)
        {
            data.DataSource = HocPhanMoDAO.Instance.LayDanhSachHocPhanMo();
        }

        public void HienThiDanhSachHocPhanMo2(DataGridView data, int mahocphan, int nam, int khoa)
        {
            data.DataSource = HocPhanMoDAO.Instance.LayDanhSachHocMo2(mahocphan, nam, khoa);
        }

        public bool ThemHocPhanMo(int mahocphan, int nam, int khoa, string phonghoc, int soluongsv, int magv)
        {
            return HocPhanMoDAO.Instance.ThemHocPhanMo(mahocphan, nam, khoa, phonghoc, soluongsv, magv);
        }

        public bool XoaHocPhanMo(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string mahocphan = row.Cells["MaHocPhan"].Value.ToString();
            string nam = row.Cells["Nam"].Value.ToString();
            string khoa = row.Cells["Khoa"].Value.ToString();


            return HocPhanMoDAO.Instance.XoaHocPhanMo(mahocphan, nam, khoa);
        }

        public bool SuaHocPhanMo(int mahocphan, int nam, int khoa, string phonghoc, int soluongsv, int magv)
        {
            return HocPhanMoDAO.Instance.SuaHocPhanMo(mahocphan, nam, khoa, phonghoc, soluongsv, magv);
        }

    }
}
