using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_DAO
{
    public class LichThiDAO
    {
        private static LichThiDAO instance;

        public static LichThiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichThiDAO();
                }

                return instance;
            }
        }

        private LichThiDAO() { }

        public DataTable Xem()
        {
            string query = "Select LT.NgayThi, CCQT.TenChungChi,  DT.DiaDiem" +
                " from ChungChiQuocTe CCQT join LichThi LT on CCQT.MaChungChi = LT.MaChungChi" +
                " join DotThi DT on LT.MaSoDotThi = DT.MaSoDotThi order by LT.NgayThi desc";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }

        public DataTable Xem_ChungChi(string tenchungchi)
        {
            string query = "Select LT.NgayThi, CCQT.TenChungChi,  DT.DiaDiem" +
                " from ChungChiQuocTe CCQT join LichThi LT on CCQT.MaChungChi = LT.MaChungChi" +
                " join DotThi DT on LT.MaSoDotThi = DT.MaSoDotThi" + 
                " where CCQT.TenChungChi = '" + tenchungchi + "' order by LT.NgayThi desc";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }

        public DataTable Xem_DiaDiem(string tendiadiem)
        {
            string query = "Select LT.NgayThi, CCQT.TenChungChi, DT.DiaDiem" +
                " from ChungChiQuocTe CCQT join LichThi LT on CCQT.MaChungChi = LT.MaChungChi" +
                " join DotThi DT on LT.MaSoDotThi = DT.MaSoDotThi" +
                " where DT.DiaDiem = '" + tendiadiem + "' order by LT.NgayThi desc";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }

        public DataTable Xem_DiaDiemvaChungChi(string tendiadiem, string tenchungchi)
        {
            string query = "Select LT.NgayThi, CCQT.TenChungChi,  DT.DiaDiem" +
                " from ChungChiQuocTe CCQT join LichThi LT on CCQT.MaChungChi = LT.MaChungChi" +
                " join DotThi DT on LT.MaSoDotThi = DT.MaSoDotThi" +
                " where DT.DiaDiem = '" + tendiadiem + "' and CCQT.TenChungChi = '" + tenchungchi + "'" +
                " order by LT.NgayThi desc";

            DataProvider.Con.Open();

            DataTable data = DataProvider.GetDataToTable(query);

            DataProvider.Con.Close();

            return data;
        }
        
    }
}
