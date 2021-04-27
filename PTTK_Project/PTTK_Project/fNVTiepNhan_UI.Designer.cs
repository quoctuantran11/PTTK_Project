
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
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnViewMark = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnroll.Location = new System.Drawing.Point(57, 51);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(160, 86);
            this.btnEnroll.TabIndex = 0;
            this.btnEnroll.Text = "Đăng ký học phần";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnViewMark
            // 
            this.btnViewMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewMark.Location = new System.Drawing.Point(335, 56);
            this.btnViewMark.Name = "btnViewMark";
            this.btnViewMark.Size = new System.Drawing.Size(190, 80);
            this.btnViewMark.TabIndex = 1;
            this.btnViewMark.Text = "Xem kết quả thi lại";
            this.btnViewMark.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(57, 174);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(159, 90);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Ghi nhận học viên";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // fNVTiepNhan_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 677);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnViewMark);
            this.Controls.Add(this.btnEnroll);
            this.Name = "fNVTiepNhan_UI";
            this.Text = "fNVTiepNhan_UI";
            this.Load += new System.EventHandler(this.fNVTiepNhan_UI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnViewMark;
        private System.Windows.Forms.Button btnRegister;
    }
}