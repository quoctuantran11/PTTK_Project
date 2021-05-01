using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    class HocVien
    {
        private string maHocVien;

        public string MaHocVien
        {
            get { return maHocVien; }
            set { maHocVien = value; }
        }

        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private string cmnd;

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        private string Diachi;

        public string DiaChi
        {
            get { return Diachi; }
            set { Diachi = value; }
        }

        private DateTime Ngaysinh;

        public DateTime NgaySinh
        {
            get { return Ngaysinh; }
            set { Ngaysinh = value; }
        }

        private string Gioitinh;

        public string GioiTinh
        {
            get { return Gioitinh; }
            set { Gioitinh = value; }
        }

        private string Sdt;

        public string SDT
        {
            get { return Sdt; }
            set { Sdt = value; }
        }

        public HocVien(string ma, string hoten, string cmnd, string diachi, DateTime ngaysinh, string gioitinh, string sdt)
        {
            this.maHocVien = ma;
            this.hoTen = hoten;
            this.cmnd = cmnd;
            this.Diachi = diachi;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
        }
    }
}
