﻿using System;
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
    public partial class fDangKyChungChiQuocTe : Form
    {
        public fDangKyChungChiQuocTe()
        {
            InitializeComponent();
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            fXemLichThi lichthi = new fXemLichThi();
            lichthi.ShowDialog();
        }
    }
}
