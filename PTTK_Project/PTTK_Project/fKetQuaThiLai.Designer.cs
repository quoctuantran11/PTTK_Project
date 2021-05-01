
namespace PTTK_Project
{
    partial class fKetQuaThiLai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvKetQuaThiLai = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnSuaDiem = new System.Windows.Forms.Button();
            this.btnXoaDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaThiLai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(34, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả thi lại";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(176, 125);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(572, 31);
            this.txbHoTen.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTim.Location = new System.Drawing.Point(770, 119);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(149, 44);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvKetQuaThiLai
            // 
            this.dgvKetQuaThiLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaThiLai.Location = new System.Drawing.Point(40, 198);
            this.dgvKetQuaThiLai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQuaThiLai.Name = "dgvKetQuaThiLai";
            this.dgvKetQuaThiLai.RowHeadersWidth = 82;
            this.dgvKetQuaThiLai.Size = new System.Drawing.Size(868, 348);
            this.dgvKetQuaThiLai.TabIndex = 4;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHienThi.Location = new System.Drawing.Point(40, 587);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(194, 61);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiện toàn bộ";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNhapDiem.Location = new System.Drawing.Point(292, 587);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(170, 61);
            this.btnNhapDiem.TabIndex = 6;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSuaDiem.Location = new System.Drawing.Point(531, 587);
            this.btnSuaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(153, 61);
            this.btnSuaDiem.TabIndex = 7;
            this.btnSuaDiem.Text = "Sửa điểm";
            this.btnSuaDiem.UseVisualStyleBackColor = true;
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // btnXoaDiem
            // 
            this.btnXoaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoaDiem.Location = new System.Drawing.Point(764, 587);
            this.btnXoaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDiem.Name = "btnXoaDiem";
            this.btnXoaDiem.Size = new System.Drawing.Size(153, 61);
            this.btnXoaDiem.TabIndex = 8;
            this.btnXoaDiem.Text = "Xóa";
            this.btnXoaDiem.UseVisualStyleBackColor = true;
            this.btnXoaDiem.Click += new System.EventHandler(this.btnXoaDiem_Click);
            // 
            // fKetQuaThiLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 679);
            this.Controls.Add(this.btnXoaDiem);
            this.Controls.Add(this.btnSuaDiem);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dgvKetQuaThiLai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fKetQuaThiLai";
            this.Text = "Kết quả thi lại";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaThiLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvKetQuaThiLai;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnSuaDiem;
        private System.Windows.Forms.Button btnXoaDiem;
    }
}