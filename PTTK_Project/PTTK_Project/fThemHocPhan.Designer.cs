
namespace PTTK_Project
{
    partial class fThemHocPhan
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
            this.txbLoaiHocPhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenHocPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(192, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Học Phần";
            // 
            // txbLoaiHocPhan
            // 
            this.txbLoaiHocPhan.Location = new System.Drawing.Point(293, 120);
            this.txbLoaiHocPhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbLoaiHocPhan.Name = "txbLoaiHocPhan";
            this.txbLoaiHocPhan.Size = new System.Drawing.Size(572, 31);
            this.txbLoaiHocPhan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại Học Phần";
            // 
            // txbTenHocPhan
            // 
            this.txbTenHocPhan.Location = new System.Drawing.Point(293, 34);
            this.txbTenHocPhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbTenHocPhan.Name = "txbTenHocPhan";
            this.txbTenHocPhan.Size = new System.Drawing.Size(572, 31);
            this.txbTenHocPhan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(41, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Học Phần";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Location = new System.Drawing.Point(451, 377);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 69);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbLoaiHocPhan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbTenHocPhan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(42, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 188);
            this.panel1.TabIndex = 3;
            // 
            // fThemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fThemHocPhan";
            this.Text = "Thêm Học Phần";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLoaiHocPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenHocPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
    }
}