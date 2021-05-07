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
    public partial class fQuanLyLichThi : Form
    {
        public fQuanLyLichThi()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemLichThi LT = new fThemLichThi();
            LT.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaLichThi LT = new fSuaLichThi();
            LT.ShowDialog();
        }

        private void fQuanLyLichThi_Load(object sender, EventArgs e)
        {
            LichThiBUS.Instance.Xem(dgvLichThi);

            cmbDiaDiem.DataSource = DotThiBUS.Instance.HienThiDiaDiemThi();
            cmbDiaDiem.DisplayMember = cmbDiaDiem.ValueMember = "DiaDiem";
            cmbDiaDiem.SelectedIndex = -1;

            cmbTenChungChi.DataSource = ChungChiQuocTeBUS.Instance.HienThiChungChi();
            cmbTenChungChi.DisplayMember = "TenChungChi";
            //cmbTenChungChi.ValueMember = "MaChungChi";
            cmbTenChungChi.SelectedIndex = -1;
        }

        private void cmbTenChungChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiaDiem.SelectedIndex == -1 && cmbTenChungChi.SelectedIndex == -1)
            {
                LichThiBUS.Instance.Xem(dgvLichThi);
            }
            else if (cmbDiaDiem.SelectedIndex == -1)
            {
                LichThiBUS.Instance.Xem_ChungChi(dgvLichThi, cmbTenChungChi.Text);
            }
            else
            {
                LichThiBUS.Instance.Xem_DiaDiemvaChungChi(dgvLichThi, cmbTenChungChi.Text, cmbDiaDiem.Text);
            }
        }

        private void cmbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiaDiem.SelectedIndex == -1 && cmbTenChungChi.SelectedIndex == -1)
            {
                LichThiBUS.Instance.Xem(dgvLichThi);
            }
            else if (cmbTenChungChi.SelectedIndex == -1)
            {
                LichThiBUS.Instance.Xem_DiaDiem(dgvLichThi, cmbDiaDiem.Text);
            }
            else
            {
                LichThiBUS.Instance.Xem_DiaDiemvaChungChi(dgvLichThi, cmbTenChungChi.Text, cmbDiaDiem.Text);
            }
        }
    }
}
