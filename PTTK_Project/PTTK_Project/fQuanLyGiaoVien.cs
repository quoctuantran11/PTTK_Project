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
    public partial class fQuanLyGiaoVien : Form
    {
        public fQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemGiaoVien GV = new fThemGiaoVien();
            GV.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaGiaoVien GV = new fSuaGiaoVien();
            GV.ShowDialog();
        }
    }
}
