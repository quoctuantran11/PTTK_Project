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
    public partial class fQuanLyHocPhanMo : Form
    {
        public fQuanLyHocPhanMo()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemHocPhanMo HP = new fThemHocPhanMo();
            HP.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaHocPhanMo HP = new fSuaHocPhanMo();
            HP.ShowDialog();
        }
    }
}
