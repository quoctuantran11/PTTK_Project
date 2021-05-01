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
    public class KetQuaThiLaiBUS
    {
        private static KetQuaThiLaiBUS instance;

        public static KetQuaThiLaiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetQuaThiLaiBUS();
                }

                return instance;
            }
        }

        private KetQuaThiLaiBUS() { }

        public void HienThiToanBo(DataGridView data)
        {
            data.DataSource = KetQuaThiLaiDAO.Instance.HienThiToanBo();
        }

        public bool TimKiem(DataGridView data, string ten)
        {
            data.DataSource = KetQuaThiLaiDAO.Instance.TimKiem(ten);

            if (data.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool XoaKetQua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string maHocVien = row.Cells["MaHocVien"].Value.ToString();
            string maHocPhan = row.Cells["MaHocPhan"].Value.ToString();
            string nam = row.Cells["Nam"].Value.ToString();
            string khoa = row.Cells["Khoa"].Value.ToString();
            DateTime Ngaythilai = (DateTime)row.Cells["NgayThiLai"].Value;
            string diem = row.Cells["Diem"].Value.ToString();
            string Solanthilai = data.CurrentRow.Cells["SoLanDaThiLai"].Value.ToString();

            KetQuaThiLai newKqtl = new KetQuaThiLai(maHocPhan, nam, khoa, maHocVien, Ngaythilai, diem, Solanthilai);

            return KetQuaThiLaiDAO.Instance.Xoa(maHocPhan, nam, khoa, maHocVien, newKqtl);
        }
    }
}
