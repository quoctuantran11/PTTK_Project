using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    public class KetQuaDangKyHocPhan
    {
        private string maHocPhan;

        public string MaHocPhan
        {
            get { return maHocPhan; }
            set { maHocPhan = value; }
        }

        private string nam;

        public string Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        private string khoa;

        public string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        private string maHocVien;

        public string MaHocVien
        {
            get { return maHocVien; }
            set { maHocVien = value; }
        }

        private string diem;

        public string Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        private string maChungChi;

        public string MaChungChi
        {
            get { return maChungChi; }
            set { maChungChi = value; }
        }

        private DateTime ngayCap;

        public DateTime NgayCap
        {
            get { return ngayCap; }
            set { ngayCap = value; }
        }

        public KetQuaDangKyHocPhan(string mahocphan, string nam, string khoa, string mahocvien, DateTime ngaycap, string diem, string machungchi)
        {
            this.maHocVien = mahocvien;
            this.maHocPhan = mahocphan;
            this.nam = nam;
            this.khoa = khoa;
            this.maChungChi = machungchi;
            this.diem = diem;
            this.ngayCap = ngaycap;
        }
    }
}
