namespace PTTK_Project
{
    partial class fHoaDonDKCCQT
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
            this.txtMaThiSinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHDDKCCQT = new System.Windows.Forms.DataGridView();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.btnHienToanBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDKCCQT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaThiSinh
            // 
            this.txtMaThiSinh.Location = new System.Drawing.Point(132, 28);
            this.txtMaThiSinh.Name = "txtMaThiSinh";
            this.txtMaThiSinh.Size = new System.Drawing.Size(261, 26);
            this.txtMaThiSinh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thí sinh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(414, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 39);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHDDKCCQT
            // 
            this.dgvHDDKCCQT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDKCCQT.Location = new System.Drawing.Point(12, 68);
            this.dgvHDDKCCQT.Name = "dgvHDDKCCQT";
            this.dgvHDDKCCQT.ReadOnly = true;
            this.dgvHDDKCCQT.RowHeadersWidth = 62;
            this.dgvHDDKCCQT.RowTemplate.Height = 28;
            this.dgvHDDKCCQT.Size = new System.Drawing.Size(749, 322);
            this.dgvHDDKCCQT.TabIndex = 3;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhiNhan.Location = new System.Drawing.Point(312, 397);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(142, 41);
            this.btnGhiNhan.TabIndex = 4;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // btnHienToanBo
            // 
            this.btnHienToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHienToanBo.Location = new System.Drawing.Point(613, 20);
            this.btnHienToanBo.Name = "btnHienToanBo";
            this.btnHienToanBo.Size = new System.Drawing.Size(145, 39);
            this.btnHienToanBo.TabIndex = 5;
            this.btnHienToanBo.Text = "Hiện toàn bộ";
            this.btnHienToanBo.UseVisualStyleBackColor = true;
            this.btnHienToanBo.Click += new System.EventHandler(this.btnHienToanBo_Click);
            // 
            // fHoaDonDKCCQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnHienToanBo);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.dgvHDDKCCQT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaThiSinh);
            this.Name = "fHoaDonDKCCQT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn đăng ký chứng chỉ quốc tế";
            this.Load += new System.EventHandler(this.fHoaDonDKCCQT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDKCCQT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaThiSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHDDKCCQT;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Button btnHienToanBo;
    }
}