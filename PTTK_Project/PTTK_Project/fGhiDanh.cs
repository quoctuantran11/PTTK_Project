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
    public partial class fGhiDanh : Form
    {
        public fGhiDanh()
        {
            InitializeComponent();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            fDKHocPhan hocphan = new fDKHocPhan();
            this.Hide();
            hocphan.ShowDialog();
            this.Show();
        }
    }
}
