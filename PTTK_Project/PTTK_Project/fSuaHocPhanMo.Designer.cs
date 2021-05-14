
namespace PTTK_Project
{
    partial class fSuaHocPhanMo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoluongSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaHocPhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.cmbNam);
            this.panel1.Controls.Add(this.cmbMaGiaoVien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSoluongSV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbMaHocPhan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 299);
            this.panel1.TabIndex = 9;
  
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(147, 65);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(288, 21);
            this.cmbKhoa.TabIndex = 16;
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(147, 19);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(288, 21);
            this.cmbNam.TabIndex = 15;
            // 
            // cmbMaGiaoVien
            // 
            this.cmbMaGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGiaoVien.FormattingEnabled = true;
            this.cmbMaGiaoVien.Location = new System.Drawing.Point(147, 249);
            this.cmbMaGiaoVien.Name = "cmbMaGiaoVien";
            this.cmbMaGiaoVien.Size = new System.Drawing.Size(288, 21);
            this.cmbMaGiaoVien.TabIndex = 14;
            this.cmbMaGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cmbMaGiaoVien_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(21, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giáo Viên";
            // 
            // txtSoluongSV
            // 
            this.txtSoluongSV.Location = new System.Drawing.Point(147, 201);
            this.txtSoluongSV.Name = "txtSoluongSV";
            this.txtSoluongSV.Size = new System.Drawing.Size(288, 20);
            this.txtSoluongSV.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(21, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số Lượng SV";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(147, 157);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(288, 20);
            this.txtPhong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phòng Học";
            // 
            // cmbMaHocPhan
            // 
            this.cmbMaHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaHocPhan.FormattingEnabled = true;
            this.cmbMaHocPhan.Location = new System.Drawing.Point(147, 112);
            this.cmbMaHocPhan.Name = "cmbMaHocPhan";
            this.cmbMaHocPhan.Size = new System.Drawing.Size(288, 21);
            this.cmbMaHocPhan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Học Phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(195, 372);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label9.Location = new System.Drawing.Point(134, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 39);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sửa Học Phần";
            // 
            // fSuaHocPhanMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label9);
            this.Name = "fSuaHocPhanMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Học Phần Mở";
            this.Load += new System.EventHandler(this.fSuaHocPhanMo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMaGiaoVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoluongSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaHocPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbNam;
    }
}