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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fBoPhanVanPhong_UI VP = new fBoPhanVanPhong_UI();
            this.Hide();
            VP.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fNVTiepNhan_UI TN = new fNVTiepNhan_UI();
            this.Hide();
            TN.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fNVKeToan_UI TN = new fNVKeToan_UI();
            this.Hide();
            TN.ShowDialog();
            this.Show();
        }
    }
}
