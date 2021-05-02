using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    public class HocPhanMo
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

        private string phongHoc;

        public string PhongHoc
        {
            get { return phongHoc; }
            set { phongHoc = value; }
        }

        private string soLuong;

        public string SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string maGiaoVien;

        public string MaGiaoVien
        {
            get { return maGiaoVien; }
            set { maGiaoVien = value; }
        }

        public HocPhanMo(string mahocphan, string nam, string khoa, string phonghoc, string sl, string magv)
        {
            this.maHocPhan = mahocphan;
            this.nam = nam;
            this.khoa = khoa;
            this.phongHoc = phonghoc;
            this.soLuong = sl;
            this.maGiaoVien = magv;
        }
    }
}
