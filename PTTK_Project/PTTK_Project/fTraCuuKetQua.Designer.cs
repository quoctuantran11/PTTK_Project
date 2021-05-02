
namespace PTTK_Project
{
    partial class fTraCuuKetQua
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
            this.dgvKetQuaHoc = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txbHocVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetQuaHoc
            // 
            this.dgvKetQuaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaHoc.Location = new System.Drawing.Point(58, 184);
            this.dgvKetQuaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQuaHoc.Name = "dgvKetQuaHoc";
            this.dgvKetQuaHoc.RowHeadersWidth = 82;
            this.dgvKetQuaHoc.Size = new System.Drawing.Size(876, 348);
            this.dgvKetQuaHoc.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(788, 118);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(146, 44);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txbHocVien
            // 
            this.txbHocVien.Location = new System.Drawing.Point(194, 124);
            this.txbHocVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbHocVien.Name = "txbHocVien";
            this.txbHocVien.Size = new System.Drawing.Size(572, 31);
            this.txbHocVien.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 67);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tra cứu kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(52, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Học viên";
            // 
            // fTraCuuKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 563);
            this.Controls.Add(this.dgvKetQuaHoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbHocVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTraCuuKetQua";
            this.Text = "Tra cứu kết quả";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKetQuaHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txbHocVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}