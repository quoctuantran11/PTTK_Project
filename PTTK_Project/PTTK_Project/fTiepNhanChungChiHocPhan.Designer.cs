
namespace PTTK_Project
{
    partial class fTiepNhanChungChiHocPhan
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
            this.lblTrungTam = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txbTrungTam = new System.Windows.Forms.TextBox();
            this.txbChungChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTrungTamNay = new System.Windows.Forms.RadioButton();
            this.rbTrungTamKhac = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTrungTam
            // 
            this.lblTrungTam.AutoSize = true;
            this.lblTrungTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTrungTam.Location = new System.Drawing.Point(24, 201);
            this.lblTrungTam.Name = "lblTrungTam";
            this.lblTrungTam.Size = new System.Drawing.Size(182, 31);
            this.lblTrungTam.TabIndex = 47;
            this.lblTrungTam.Text = "Tên trung tâm";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.AutoSize = true;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKiemTra.Location = new System.Drawing.Point(690, 77);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(135, 45);
            this.btnKiemTra.TabIndex = 46;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txbTrungTam
            // 
            this.txbTrungTam.Location = new System.Drawing.Point(235, 201);
            this.txbTrungTam.Name = "txbTrungTam";
            this.txbTrungTam.Size = new System.Drawing.Size(428, 31);
            this.txbTrungTam.TabIndex = 45;
            // 
            // txbChungChi
            // 
            this.txbChungChi.Location = new System.Drawing.Point(235, 87);
            this.txbChungChi.Name = "txbChungChi";
            this.txbChungChi.Size = new System.Drawing.Size(428, 31);
            this.txbChungChi.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(24, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nơi cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mã chứng chỉ";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHoanThanh.Location = new System.Drawing.Point(352, 249);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(154, 53);
            this.btnHoanThanh.TabIndex = 48;
            this.btnHoanThanh.Text = "Hoàn tất";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(235, 30);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(428, 31);
            this.txbHoTen.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên học viên";
            // 
            // rbTrungTamNay
            // 
            this.rbTrungTamNay.AutoSize = true;
            this.rbTrungTamNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTrungTamNay.Location = new System.Drawing.Point(235, 144);
            this.rbTrungTamNay.Name = "rbTrungTamNay";
            this.rbTrungTamNay.Size = new System.Drawing.Size(227, 33);
            this.rbTrungTamNay.TabIndex = 51;
            this.rbTrungTamNay.TabStop = true;
            this.rbTrungTamNay.Text = "Tại trung tâm này";
            this.rbTrungTamNay.UseVisualStyleBackColor = true;
            this.rbTrungTamNay.CheckedChanged += new System.EventHandler(this.rbTrungTamNay_CheckedChanged);
            // 
            // rbTrungTamKhac
            // 
            this.rbTrungTamKhac.AutoSize = true;
            this.rbTrungTamKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTrungTamKhac.Location = new System.Drawing.Point(477, 144);
            this.rbTrungTamKhac.Name = "rbTrungTamKhac";
            this.rbTrungTamKhac.Size = new System.Drawing.Size(209, 33);
            this.rbTrungTamKhac.TabIndex = 52;
            this.rbTrungTamKhac.TabStop = true;
            this.rbTrungTamKhac.Text = "Trung tâm khác";
            this.rbTrungTamKhac.UseVisualStyleBackColor = true;
            this.rbTrungTamKhac.CheckedChanged += new System.EventHandler(this.rbTrungTamKhac_CheckedChanged);
            // 
            // fTiepNhanChungChiHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 321);
            this.Controls.Add(this.rbTrungTamKhac);
            this.Controls.Add(this.rbTrungTamNay);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.lblTrungTam);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txbTrungTam);
            this.Controls.Add(this.txbChungChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "fTiepNhanChungChiHocPhan";
            this.Text = "Tiếp nhận chứng chỉ học phần cơ bản";
            this.Load += new System.EventHandler(this.fKiemTraChungChiHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrungTam;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txbTrungTam;
        private System.Windows.Forms.TextBox txbChungChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTrungTamNay;
        private System.Windows.Forms.RadioButton rbTrungTamKhac;
    }
}