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
        }
    }
}
