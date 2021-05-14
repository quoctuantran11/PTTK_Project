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
    public partial class fQuanLyHocPhan : Form
    {
        public fQuanLyHocPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemHocPhan HP = new fThemHocPhan();
            HP.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaHocPhan HP = new fSuaHocPhan();
            HP.ShowDialog();
        }

        private void fQuanLyHocPhan_Load(object sender, EventArgs e)
        {
            HocPhanBUS.Instance.XemToanBo(dgvHocPhan);
        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            HocPhanBUS.Instance.XemToanBo(dgvHocPhan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(HocPhanBUS.Instance.XoaHocPhan(dgvHocPhan))
            {
                MessageBox.Show("Xóa thành công!","Thông báo");
            }
            else
            {
                MessageBox.Show("Dữ liệu này hiện không thể xóa!", "Thông báo");
            }
        }
    }
}
