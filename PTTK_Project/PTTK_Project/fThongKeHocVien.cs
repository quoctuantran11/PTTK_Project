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
    public partial class fThongKeHocVien : Form
    {
        public fThongKeHocVien()
        {
            InitializeComponent();
        }

        private void fThongKeHocVien_Load(object sender, EventArgs e)
        {
            KetQuaDangKyHocPhanBUS.Instance.DemHocVien(dgvKetQua);

            cmbNam.SelectedIndexChanged -= cmbNam_SelectedIndexChanged;
            cmbNam.DataSource = KetQuaDangKyHocPhanBUS.Instance.HienNam();
            cmbNam.DisplayMember = "Nam";
            cmbNam.SelectedIndexChanged += cmbNam_SelectedIndexChanged;

            cmbQuy.SelectedIndexChanged -= cmbQuy_SelectedIndexChanged;
            cmbQuy.DataSource = KetQuaDangKyHocPhanBUS.Instance.HienKhoa();
            cmbQuy.DisplayMember = "Khoa";
            cmbQuy.SelectedIndexChanged += cmbQuy_SelectedIndexChanged;
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedIndex == -1 && cmbQuy.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.DemHocVien(dgvKetQua);
            }
            else if(cmbQuy.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.ThongKeTheoNam(dgvKetQua,cmbNam.Text);
            }
            else
            {
                KetQuaDangKyHocPhanBUS.Instance.ThongKeTheoNamvaQuy(dgvKetQua, cmbNam.Text, cmbQuy.Text);
            }
        }

        private void cmbQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedIndex == -1 && cmbQuy.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.DemHocVien(dgvKetQua);
            }
            else if (cmbNam.SelectedIndex == -1)
            {
                KetQuaDangKyHocPhanBUS.Instance.ThongKeTheoQuy(dgvKetQua, cmbQuy.Text);
            }
            else
            {
                KetQuaDangKyHocPhanBUS.Instance.ThongKeTheoNamvaQuy(dgvKetQua, cmbNam.Text, cmbQuy.Text);
            }
        }

        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            KetQuaDangKyHocPhanBUS.Instance.DemHocVien(dgvKetQua);
        }
    }
}
