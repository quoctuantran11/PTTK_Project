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
    public partial class fGhiNhanHDDKCCQT : Form
    {
        public fGhiNhanHDDKCCQT()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string mathisinh = txtMaThiSinh.Text;
            if(GhiNhanHDDKCCQTBUS.Instance.KiemTraHocVien(mathisinh))
            {
                rbTrongTrungTam.Checked = true;
                int tongtien = Int32.Parse(txtTongTien.Text);
                int giamgia = tongtien / 100 * 10;

                tongtien = tongtien - giamgia;

                txtTongTien.Text = tongtien.ToString();
                txtGiamGia.Text = giamgia.ToString();
            }
            else
            {
                rbBenNgoai.Checked = true;
            }

        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = dtpNgayLap.Value;
            int tongtien = Int32.Parse(txtTongTien.Text);
            int mathisinh = Int32.Parse(txtMaThiSinh.Text);
            int giamgia = Int32.Parse(txtGiamGia.Text);
            if(GhiNhanHDDKCCQTBUS.Instance.GhiNhan(ngaylap, giamgia, tongtien, mathisinh))
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
