using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK_BUS;

namespace PTTK_Project
{
    public partial class fXemKQTL : Form
    {
        public fXemKQTL()
        {
            InitializeComponent();
        }

        private void btnHientoanbo_Click(object sender, EventArgs e)
        {
            KetQuaThiLaiBUS.Instance.HienThiToanBo(dgvKetqua);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txbHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
            }
            else
            {
                if (!KetQuaThiLaiBUS.Instance.TimKiem(dgvKetqua, txbHoten.Text))
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo");
                }
            }
        }

        private void fXemKQTL_Load(object sender, EventArgs e)
        {
            KetQuaThiLaiBUS.Instance.HienThiToanBo(dgvKetqua);
        }
    }
}
