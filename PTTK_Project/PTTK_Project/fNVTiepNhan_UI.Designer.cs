
namespace PTTK_Project
{
    partial class fNVTiepNhan_UI
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
            this.btnDKHP = new System.Windows.Forms.Button();
            this.btnXKQTL = new System.Windows.Forms.Button();
            this.btnGNHV = new System.Windows.Forms.Button();
            this.btnGNNTDT = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDKHP
            // 
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDKHP.Location = new System.Drawing.Point(48, 52);
            this.btnDKHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(288, 87);
            this.btnDKHP.TabIndex = 0;
            this.btnDKHP.Text = "Đăng ký học phần";
            this.btnDKHP.UseVisualStyleBackColor = true;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
            // 
            // btnXKQTL
            // 
            this.btnXKQTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXKQTL.Location = new System.Drawing.Point(378, 183);
            this.btnXKQTL.Margin = new System.Windows.Forms.Padding(4);
            this.btnXKQTL.Name = "btnXKQTL";
            this.btnXKQTL.Size = new System.Drawing.Size(272, 81);
            this.btnXKQTL.TabIndex = 1;
            this.btnXKQTL.Text = "Xem kết quả thi lại";
            this.btnXKQTL.UseVisualStyleBackColor = true;
            this.btnXKQTL.Click += new System.EventHandler(this.btnXKQTL_Click);
            // 
            // btnGNHV
            // 
            this.btnGNHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGNHV.Location = new System.Drawing.Point(48, 179);
            this.btnGNHV.Margin = new System.Windows.Forms.Padding(4);
            this.btnGNHV.Name = "btnGNHV";
            this.btnGNHV.Size = new System.Drawing.Size(288, 85);
            this.btnGNHV.TabIndex = 2;
            this.btnGNHV.Text = "Ghi nhận học viên";
            this.btnGNHV.UseVisualStyleBackColor = true;
            this.btnGNHV.Click += new System.EventHandler(this.btnGNHV_Click);
            // 
            // btnGNNTDT
            // 
            this.btnGNNTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGNNTDT.Location = new System.Drawing.Point(378, 52);
            this.btnGNNTDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnGNNTDT.Name = "btnGNNTDT";
            this.btnGNNTDT.Size = new System.Drawing.Size(272, 87);
            this.btnGNNTDT.TabIndex = 3;
            this.btnGNNTDT.Text = "Ghi nhận người tham dự thi";
            this.btnGNNTDT.UseVisualStyleBackColor = true;
            this.btnGNNTDT.Click += new System.EventHandler(this.btnGNNTDT_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThongKe.Location = new System.Drawing.Point(48, 304);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(602, 85);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê số lượng học viên từng học phần theo năm/quý";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // fNVTiepNhan_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 431);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnGNNTDT);
            this.Controls.Add(this.btnGNHV);
            this.Controls.Add(this.btnXKQTL);
            this.Controls.Add(this.btnDKHP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNVTiepNhan_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên Tiếp Nhận";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDKHP;
        private System.Windows.Forms.Button btnXKQTL;
        private System.Windows.Forms.Button btnGNHV;
        private System.Windows.Forms.Button btnGNNTDT;
        private System.Windows.Forms.Button btnThongKe;
    }
}