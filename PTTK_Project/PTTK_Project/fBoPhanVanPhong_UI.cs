using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_Project
{
    public partial class fBoPhanVanPhong_UI : Form
    {
        public fBoPhanVanPhong_UI()
        {
            InitializeComponent();
        }

        private void btnQLHP_Click(object sender, EventArgs e)
        {
            fQuanLyHocPhan QLHP = new fQuanLyHocPhan();
            this.Hide();
            QLHP.ShowDialog();
            this.Show();
        }

        private void btnQLHPM_Click(object sender, EventArgs e)
        {
            fQuanLyHocPhanMo QLHP = new fQuanLyHocPhanMo();
            this.Hide();
            QLHP.ShowDialog();
            this.Show();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            fQuanLyGiaoVien QLGV = new fQuanLyGiaoVien();
            this.Hide();
            QLGV.ShowDialog();
            this.Show();
        }

        private void btnQLLT_Click(object sender, EventArgs e)
        {
            fQuanLyLichThi QLLT = new fQuanLyLichThi();
            this.Hide();
            QLLT.ShowDialog();
            this.Show();
        }

        private void btnQLDKHP_Click(object sender, EventArgs e)
        {
            fQLDangKyHocPhan QLDKHP = new fQLDangKyHocPhan();
            this.Hide();
            QLDKHP.ShowDialog();
            this.Show();
        }

        private void btnQLKQTL_Click(object sender, EventArgs e)
        {
            fKetQuaThiLai QLKQTL = new fKetQuaThiLai();
            this.Hide();
            QLKQTL.ShowDialog();
            this.Show();
        }
    }
}
