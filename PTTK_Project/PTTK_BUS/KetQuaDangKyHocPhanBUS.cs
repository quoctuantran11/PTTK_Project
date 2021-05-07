using System;
using System.Collections.Generic;
using System.Data;
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

        public void HienToanBo(DataGridView data)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.HienToanBo();
        }

        public void HienTheoNam(DataGridView data, string ten, string nam)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.HienTheoNam(ten, nam);
        }

        public void HienTheoKhoa(DataGridView data, string ten, string khoa)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.HienTheoKhoa(ten, khoa);
        }

        public void HienTheoNamvaKhoa(DataGridView data, string ten, string nam, string khoa)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.HienTheoNamvaKhoa(ten, nam, khoa);
        }

        public DataTable HienNamvaKhoa()
        {
            return KetQuaDangKyHocPhanDAO.Instance.HienNamvaKhoa();
        }

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

        public bool XoaDKHP(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string tenHocVien = row.Cells["HoTen"].Value.ToString();
            string tenHocPhan = row.Cells["TenHocPhan"].Value.ToString();
            string nam = row.Cells["Nam"].Value.ToString();
            string khoa = row.Cells["Khoa"].Value.ToString();

            return KetQuaDangKyHocPhanDAO.Instance.XoaDKHP(tenHocPhan, nam, khoa, tenHocVien);
        }

        public void DemHocVien(DataGridView data)
        {
            data.DataSource = KetQuaDangKyHocPhanDAO.Instance.DemHocVien();
        }
    }
}
