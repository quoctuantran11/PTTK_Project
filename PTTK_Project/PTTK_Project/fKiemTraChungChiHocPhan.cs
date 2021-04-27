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
    public partial class fKiemTraChungChiHocPhan : Form
    {
        public fKiemTraChungChiHocPhan()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                textBox2.Enabled = false;
                label7.Visible = false;

                textBox2.Text = "";
            }
        }
    
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                    checkBox1.Checked = false;
                    textBox2.Enabled = true;
                    label7.Visible = true;
            }
        }
        
    }
}
