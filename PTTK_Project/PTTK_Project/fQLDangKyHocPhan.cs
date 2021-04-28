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
    public partial class fQLDangKyHocPhan : Form
    {
        public fQLDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fDKHocPhan dk = new fDKHocPhan();
            dk.ShowDialog();
        }
    }
}
