
namespace PTTK_Project
{
    partial class fXemKQTL
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
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHientoanbo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Location = new System.Drawing.Point(52, 260);
            this.dgvKetqua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetqua.Name = "dgvKetqua";
            this.dgvKetqua.RowHeadersWidth = 82;
            this.dgvKetqua.Size = new System.Drawing.Size(876, 348);
            this.dgvKetqua.TabIndex = 9;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimkiem.Location = new System.Drawing.Point(782, 129);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(146, 44);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(188, 135);
            this.txbHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(572, 31);
            this.txbHoten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả thi lại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(46, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Học viên";
            // 
            // btnHientoanbo
            // 
            this.btnHientoanbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHientoanbo.Location = new System.Drawing.Point(52, 200);
            this.btnHientoanbo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHientoanbo.Name = "btnHientoanbo";
            this.btnHientoanbo.Size = new System.Drawing.Size(330, 52);
            this.btnHientoanbo.TabIndex = 10;
            this.btnHientoanbo.Text = "Hiện toàn bộ danh sách";
            this.btnHientoanbo.UseVisualStyleBackColor = true;
            this.btnHientoanbo.Click += new System.EventHandler(this.btnHientoanbo_Click);
            // 
            // fXemKQTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 644);
            this.Controls.Add(this.btnHientoanbo);
            this.Controls.Add(this.dgvKetqua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txbHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fXemKQTL";
            this.Text = "XemKQTL";
            this.Load += new System.EventHandler(this.fXemKQTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKetqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHientoanbo;
    }
}