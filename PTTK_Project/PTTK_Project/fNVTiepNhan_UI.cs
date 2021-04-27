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
    public partial class fNVTiepNhan_UI : Form
    {
        public fNVTiepNhan_UI()
        {
            InitializeComponent();
        }

        private void fNVTiepNhan_UI_Load(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            DKHocPhan dkhp = new DKHocPhan();

            dkhp.ShowDialog();
            this.Hide();
        }
    }
}
