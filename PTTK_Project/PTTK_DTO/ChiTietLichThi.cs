using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DTO
{
    public class ChiTietLichThi
    {
        private string masoDotThi;

        public string MaSoDotThi
        {
            get { return masoDotThi; }
            set { masoDotThi = value; }
        }

        private string maChungChi;

        public string MaChungChi
        {
            get { return maChungChi; }
            set { maChungChi = value; }
        }

        private string maThiSinh;

        public string MaThiSinh
        {
            get { return maThiSinh; }
            set { maThiSinh = value; }
        }

        public ChiTietLichThi(string masodotthi, string machungchi, string mathisinh)
        {
            this.masoDotThi = masodotthi;
            this.maChungChi = machungchi;
            this.maThiSinh = mathisinh;
        }
    }
}
