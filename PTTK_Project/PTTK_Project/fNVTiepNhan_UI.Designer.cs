
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
            this.btnTraCuuKQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDKHP
            // 
            this.btnDKHP.BackColor = System.Drawing.SystemColors.Window;
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKHP.Location = new System.Drawing.Point(25, 95);
            this.btnDKHP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(144, 42);
            this.btnDKHP.TabIndex = 0;
            this.btnDKHP.Text = "Đăng ký học phần";
            this.btnDKHP.UseVisualStyleBackColor = false;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
            // 
            // btnXKQTL
            // 
            this.btnXKQTL.BackColor = System.Drawing.SystemColors.Window;
            this.btnXKQTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXKQTL.Location = new System.Drawing.Point(189, 27);
            this.btnXKQTL.Margin = new System.Windows.Forms.Padding(2);
            this.btnXKQTL.Name = "btnXKQTL";
            this.btnXKQTL.Size = new System.Drawing.Size(151, 42);
            this.btnXKQTL.TabIndex = 1;
            this.btnXKQTL.Text = "Xem kết quả thi lại";
            this.btnXKQTL.UseVisualStyleBackColor = false;
            this.btnXKQTL.Click += new System.EventHandler(this.btnXKQTL_Click);
            // 
            // btnGNHV
            // 
            this.btnGNHV.BackColor = System.Drawing.SystemColors.Window;
            this.btnGNHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGNHV.Location = new System.Drawing.Point(25, 27);
            this.btnGNHV.Margin = new System.Windows.Forms.Padding(2);
            this.btnGNHV.Name = "btnGNHV";
            this.btnGNHV.Size = new System.Drawing.Size(144, 42);
            this.btnGNHV.TabIndex = 2;
            this.btnGNHV.Text = "Ghi nhận học viên";
            this.btnGNHV.UseVisualStyleBackColor = false;
            this.btnGNHV.Click += new System.EventHandler(this.btnGNHV_Click);
            // 
            // btnGNNTDT
            // 
            this.btnGNNTDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnGNNTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGNNTDT.Location = new System.Drawing.Point(189, 95);
            this.btnGNNTDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnGNNTDT.Name = "btnGNNTDT";
            this.btnGNNTDT.Size = new System.Drawing.Size(151, 42);
            this.btnGNNTDT.TabIndex = 3;
            this.btnGNNTDT.Text = "Ghi nhận người tham dự thi";
            this.btnGNNTDT.UseVisualStyleBackColor = false;
            this.btnGNNTDT.Click += new System.EventHandler(this.btnGNNTDT_Click);
            // 
            // btnTraCuuKQ
            // 
            this.btnTraCuuKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnTraCuuKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuKQ.Location = new System.Drawing.Point(101, 164);
            this.btnTraCuuKQ.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuuKQ.Name = "btnTraCuuKQ";
            this.btnTraCuuKQ.Size = new System.Drawing.Size(151, 42);
            this.btnTraCuuKQ.TabIndex = 4;
            this.btnTraCuuKQ.Text = "Tra cứu kết quả";
            this.btnTraCuuKQ.UseVisualStyleBackColor = false;
            // 
            // fNVTiepNhan_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 223);
            this.Controls.Add(this.btnTraCuuKQ);
            this.Controls.Add(this.btnGNNTDT);
            this.Controls.Add(this.btnGNHV);
            this.Controls.Add(this.btnXKQTL);
            this.Controls.Add(this.btnDKHP);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnTraCuuKQ;
    }
}