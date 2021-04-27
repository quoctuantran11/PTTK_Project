
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
            this.btnViewMark = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDKHP
            // 
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDKHP.Location = new System.Drawing.Point(24, 27);
            this.btnDKHP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(144, 45);
            this.btnDKHP.TabIndex = 0;
            this.btnDKHP.Text = "Đăng ký học phần";
            this.btnDKHP.UseVisualStyleBackColor = true;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
            // 
            // btnViewMark
            // 
            this.btnViewMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewMark.Location = new System.Drawing.Point(189, 95);
            this.btnViewMark.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMark.Name = "btnViewMark";
            this.btnViewMark.Size = new System.Drawing.Size(136, 42);
            this.btnViewMark.TabIndex = 1;
            this.btnViewMark.Text = "Xem kết quả thi lại";
            this.btnViewMark.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(24, 93);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(144, 44);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Ghi nhận học viên";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(189, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ghi nhận người tham dự thi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fNVTiepNhan_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnViewMark);
            this.Controls.Add(this.btnDKHP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fNVTiepNhan_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên Tiếp Nhận";
            this.Load += new System.EventHandler(this.fNVTiepNhan_UI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDKHP;
        private System.Windows.Forms.Button btnViewMark;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
    }
}