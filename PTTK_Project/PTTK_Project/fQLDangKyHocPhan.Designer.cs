
namespace PTTK_Project
{
    partial class fQLDangKyHocPhan
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
            this.dgvDKHP = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienToanBo = new System.Windows.Forms.Button();
            this.Namcmb = new System.Windows.Forms.ComboBox();
            this.Khoacmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDKHP
            // 
            this.dgvDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKHP.Location = new System.Drawing.Point(42, 122);
            this.dgvDKHP.Name = "dgvDKHP";
            this.dgvDKHP.RowHeadersWidth = 82;
            this.dgvDKHP.RowTemplate.Height = 33;
            this.dgvDKHP.Size = new System.Drawing.Size(550, 237);
            this.dgvDKHP.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(641, 317);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 42);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(638, 244);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txbHoten
            // 
            this.txbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txbHoten.Location = new System.Drawing.Point(131, 50);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(328, 28);
            this.txbHoten.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Học viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(476, 46);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 38);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHienToanBo
            // 
            this.btnHienToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHienToanBo.Location = new System.Drawing.Point(199, 380);
            this.btnHienToanBo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienToanBo.Name = "btnHienToanBo";
            this.btnHienToanBo.Size = new System.Drawing.Size(192, 42);
            this.btnHienToanBo.TabIndex = 25;
            this.btnHienToanBo.Text = "Hiện toàn bộ";
            this.btnHienToanBo.UseVisualStyleBackColor = true;
            this.btnHienToanBo.Click += new System.EventHandler(this.btnHienToanBo_Click);
            // 
            // Namcmb
            // 
            this.Namcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Namcmb.FormattingEnabled = true;
            this.Namcmb.Location = new System.Drawing.Point(673, 122);
            this.Namcmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Namcmb.Name = "Namcmb";
            this.Namcmb.Size = new System.Drawing.Size(98, 30);
            this.Namcmb.TabIndex = 26;
            this.Namcmb.Text = "Năm";
            this.Namcmb.SelectedIndexChanged += new System.EventHandler(this.Namcmb_SelectedIndexChanged);
            // 
            // Khoacmb
            // 
            this.Khoacmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Khoacmb.FormattingEnabled = true;
            this.Khoacmb.Location = new System.Drawing.Point(673, 172);
            this.Khoacmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Khoacmb.Name = "Khoacmb";
            this.Khoacmb.Size = new System.Drawing.Size(98, 30);
            this.Khoacmb.TabIndex = 27;
            this.Khoacmb.Text = "Khóa";
            this.Khoacmb.SelectedIndexChanged += new System.EventHandler(this.Khoacmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(609, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(605, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Khóa";
            // 
            // fQLDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Khoacmb);
            this.Controls.Add(this.Namcmb);
            this.Controls.Add(this.btnHienToanBo);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txbHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvDKHP);
            this.Name = "fQLDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đăng Ký Học Phần";
            this.Load += new System.EventHandler(this.fQLDangKyHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDKHP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienToanBo;
        private System.Windows.Forms.ComboBox Namcmb;
        private System.Windows.Forms.ComboBox Khoacmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}