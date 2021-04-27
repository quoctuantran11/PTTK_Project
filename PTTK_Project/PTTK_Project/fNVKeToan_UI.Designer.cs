
namespace PTTK_Project
{
    partial class fNVKeToan_UI
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
            this.btnCapPhieuDuThi = new System.Windows.Forms.Button();
            this.btnGhiNhanHDDKHP = new System.Windows.Forms.Button();
            this.btnGhiNhanHDDKCCQT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapPhieuDuThi
            // 
            this.btnCapPhieuDuThi.BackColor = System.Drawing.SystemColors.Window;
            this.btnCapPhieuDuThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapPhieuDuThi.Location = new System.Drawing.Point(15, 104);
            this.btnCapPhieuDuThi.Name = "btnCapPhieuDuThi";
            this.btnCapPhieuDuThi.Size = new System.Drawing.Size(143, 30);
            this.btnCapPhieuDuThi.TabIndex = 0;
            this.btnCapPhieuDuThi.Text = "Cấp Phiếu Dự Thi";
            this.btnCapPhieuDuThi.UseVisualStyleBackColor = false;
            this.btnCapPhieuDuThi.Click += new System.EventHandler(this.btnCapPhieuDuThi_Click);
            // 
            // btnGhiNhanHDDKHP
            // 
            this.btnGhiNhanHDDKHP.BackColor = System.Drawing.SystemColors.Window;
            this.btnGhiNhanHDDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNhanHDDKHP.Location = new System.Drawing.Point(209, 116);
            this.btnGhiNhanHDDKHP.Name = "btnGhiNhanHDDKHP";
            this.btnGhiNhanHDDKHP.Size = new System.Drawing.Size(125, 60);
            this.btnGhiNhanHDDKHP.TabIndex = 2;
            this.btnGhiNhanHDDKHP.Text = "Ghi Nhận Hoá Đơn Đăng Ký Học Phần";
            this.btnGhiNhanHDDKHP.UseVisualStyleBackColor = false;
            this.btnGhiNhanHDDKHP.Click += new System.EventHandler(this.btnGhiNhanHDDKHP_Click);
            // 
            // btnGhiNhanHDDKCCQT
            // 
            this.btnGhiNhanHDDKCCQT.BackColor = System.Drawing.SystemColors.Window;
            this.btnGhiNhanHDDKCCQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNhanHDDKCCQT.Location = new System.Drawing.Point(15, 19);
            this.btnGhiNhanHDDKCCQT.Name = "btnGhiNhanHDDKCCQT";
            this.btnGhiNhanHDDKCCQT.Size = new System.Drawing.Size(143, 68);
            this.btnGhiNhanHDDKCCQT.TabIndex = 1;
            this.btnGhiNhanHDDKCCQT.Text = "Ghi Nhận Hoá Đơn Đăng Ký Chứng Chỉ Quốc Tế";
            this.btnGhiNhanHDDKCCQT.UseVisualStyleBackColor = false;
            this.btnGhiNhanHDDKCCQT.Click += new System.EventHandler(this.btnGhiNhanHDDKCCQT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnGhiNhanHDDKCCQT);
            this.panel1.Controls.Add(this.btnCapPhieuDuThi);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 154);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Học Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chứng Chỉ Quốc Tế";
            // 
            // fNVKeToan_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGhiNhanHDDKHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fNVKeToan_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên Kế Toán";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapPhieuDuThi;
        private System.Windows.Forms.Button btnGhiNhanHDDKHP;
        private System.Windows.Forms.Button btnGhiNhanHDDKCCQT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}