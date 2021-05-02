using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    public class HocPhan
    {
        private string maHocPhan;

        public string MaHocPhan
        {
            get { return maHocPhan; }
            set { maHocPhan = value; }
        }

        private string loaiHocPhan;

        public string LoaiHocPhan
        {
            get { return loaiHocPhan; }
            set { loaiHocPhan = value; }
        }

        private string tenHocPhan;

        public string TenHocPhan
        {
            get { return tenHocPhan; }
            set { tenHocPhan = value; }
        }

        public HocPhan(string mahocphan, string loaihp, string tenhp)
        {
            this.maHocPhan = mahocphan;
            this.loaiHocPhan = loaihp;
            this.tenHocPhan = tenhp;
        }
    }
}
