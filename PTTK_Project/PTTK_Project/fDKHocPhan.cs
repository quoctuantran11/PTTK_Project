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
    public partial class fDKHocPhan : Form
    {
        public fDKHocPhan()
        {
            InitializeComponent();
        }

        private void btnGNCC_Click(object sender, EventArgs e)
        {
            fKiemTraChungChiHocPhan kiemtra = new fKiemTraChungChiHocPhan();
            this.Hide();
            kiemtra.ShowDialog();
            this.Show();
        }
    }
}
