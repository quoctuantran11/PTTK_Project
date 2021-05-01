using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    public class KetQuaThiLai
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

        private DateTime Ngaythilai;

        public DateTime NgayThiLai
        {
            get { return Ngaythilai; }
            set { Ngaythilai = value; }
        }

        private string Solanthilai;

        public string SoLanDaThiLai
        {
            get { return Solanthilai; }
            set { Solanthilai = value; }
        }

        public KetQuaThiLai(string mahocphan, string nam, string khoa, string mahocvien, DateTime ngaythilai, string diem, string solanthilai)
        {
            this.maHocVien = mahocvien;
            this.maHocPhan = mahocphan;
            this.nam = nam;
            this.khoa = khoa;
            this.Ngaythilai = ngaythilai;
            this.diem = diem;
            this.Solanthilai = solanthilai;
        }
    }
}
