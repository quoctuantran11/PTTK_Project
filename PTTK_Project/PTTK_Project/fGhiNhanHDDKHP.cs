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
    public partial class fGhiNhanHDDKHP : Form
    {
        public fGhiNhanHDDKHP()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = dtpNgayLap.Value;
            int tongtien = Int32.Parse(txtTongTien.Text);
            int mahocvien = Int32.Parse(txtMaHocVien.Text);

            if (GhiNhanHDDKHPBUS.Instance.GhiNhan(ngaylap, tongtien, mahocvien))
            {
                MessageBox.Show("Ghi nhận thành công!");
            }
            else
            {
                MessageBox.Show("Ghi nhận thất bại!");
            }
        }
    }
}
