
namespace PTTK_Project
{
    partial class fDKHocPhan
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
            this.cmbHocPhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbLoaiHocPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGNCC = new System.Windows.Forms.Button();
            this.btnKiemTraSiSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 67);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đăng ký học phần";
            // 
            // cmbHocPhan
            // 
            this.cmbHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbHocPhan.FormattingEnabled = true;
            this.cmbHocPhan.Location = new System.Drawing.Point(248, 315);
            this.cmbHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHocPhan.Name = "cmbHocPhan";
            this.cmbHocPhan.Size = new System.Drawing.Size(530, 37);
            this.cmbHocPhan.TabIndex = 30;
            this.cmbHocPhan.SelectedIndexChanged += new System.EventHandler(this.cmbHocPhan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên học phần";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXacNhan.Location = new System.Drawing.Point(326, 535);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(156, 60);
            this.btnXacNhan.TabIndex = 38;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cmbNam
            // 
            this.cmbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(248, 183);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(134, 37);
            this.cmbNam.TabIndex = 40;
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.cmbNam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(32, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Năm";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(248, 248);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(134, 37);
            this.cmbKhoa.TabIndex = 42;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(32, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Khóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(32, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 31);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tên học viên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(248, 121);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(530, 31);
            this.txbHoTen.TabIndex = 44;
            // 
            // txbLoaiHocPhan
            // 
            this.txbLoaiHocPhan.Location = new System.Drawing.Point(248, 379);
            this.txbLoaiHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txbLoaiHocPhan.Name = "txbLoaiHocPhan";
            this.txbLoaiHocPhan.ReadOnly = true;
            this.txbLoaiHocPhan.Size = new System.Drawing.Size(316, 31);
            this.txbLoaiHocPhan.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Loại học phần";
            // 
            // btnGNCC
            // 
            this.btnGNCC.AutoSize = true;
            this.btnGNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGNCC.Location = new System.Drawing.Point(248, 448);
            this.btnGNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGNCC.Name = "btnGNCC";
            this.btnGNCC.Size = new System.Drawing.Size(320, 52);
            this.btnGNCC.TabIndex = 47;
            this.btnGNCC.Text = "Ghi nhận chứng chỉ";
            this.btnGNCC.UseVisualStyleBackColor = true;
            this.btnGNCC.Click += new System.EventHandler(this.btnGNCC_Click);
            // 
            // btnKiemTraSiSo
            // 
            this.btnKiemTraSiSo.AutoSize = true;
            this.btnKiemTraSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKiemTraSiSo.Location = new System.Drawing.Point(576, 371);
            this.btnKiemTraSiSo.Margin = new System.Windows.Forms.Padding(4);
            this.btnKiemTraSiSo.Name = "btnKiemTraSiSo";
            this.btnKiemTraSiSo.Size = new System.Drawing.Size(206, 52);
            this.btnKiemTraSiSo.TabIndex = 48;
            this.btnKiemTraSiSo.Text = "Kiểm tra sĩ số";
            this.btnKiemTraSiSo.UseVisualStyleBackColor = true;
            this.btnKiemTraSiSo.Click += new System.EventHandler(this.btnKiemTraSiSo_Click);
            // 
            // fDKHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 615);
            this.Controls.Add(this.btnKiemTraSiSo);
            this.Controls.Add(this.btnGNCC);
            this.Controls.Add(this.txbLoaiHocPhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cmbHocPhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDKHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký học phần";
            this.Load += new System.EventHandler(this.fDKHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHocPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbLoaiHocPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGNCC;
        private System.Windows.Forms.Button btnKiemTraSiSo;
    }
}