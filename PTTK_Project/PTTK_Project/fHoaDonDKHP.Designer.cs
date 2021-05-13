namespace PTTK_Project
{
    partial class fHoaDonDKHP
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
            this.txtMahocVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHDDKHP = new System.Windows.Forms.DataGridView();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.btnHienToanBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMahocVien
            // 
            this.txtMahocVien.Location = new System.Drawing.Point(159, 27);
            this.txtMahocVien.Name = "txtMahocVien";
            this.txtMahocVien.Size = new System.Drawing.Size(307, 26);
            this.txtMahocVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(496, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 49);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvHDDKHP
            // 
            this.dgvHDDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDKHP.Location = new System.Drawing.Point(17, 77);
            this.dgvHDDKHP.Name = "dgvHDDKHP";
            this.dgvHDDKHP.RowHeadersWidth = 62;
            this.dgvHDDKHP.RowTemplate.Height = 28;
            this.dgvHDDKHP.Size = new System.Drawing.Size(761, 316);
            this.dgvHDDKHP.TabIndex = 3;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(300, 414);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(166, 49);
            this.btnGhiNhan.TabIndex = 4;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // btnHienToanBo
            // 
            this.btnHienToanBo.Location = new System.Drawing.Point(654, 16);
            this.btnHienToanBo.Name = "btnHienToanBo";
            this.btnHienToanBo.Size = new System.Drawing.Size(124, 49);
            this.btnHienToanBo.TabIndex = 5;
            this.btnHienToanBo.Text = "Hiện toàn bộ";
            this.btnHienToanBo.UseVisualStyleBackColor = true;
            this.btnHienToanBo.Click += new System.EventHandler(this.btnHienToanBo_Click);
            // 
            // fHoaDonDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnHienToanBo);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.dgvHDDKHP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMahocVien);
            this.Name = "fHoaDonDKHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn đăng ký học phần";
            this.Load += new System.EventHandler(this.fHoaDonDKHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMahocVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHDDKHP;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Button btnHienToanBo;
    }
}