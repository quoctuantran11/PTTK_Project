
namespace PTTK_Project
{
    partial class fThongKeHocVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbQuy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(999, 507);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbNam
            // 
            this.cmbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(714, 90);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(140, 37);
            this.cmbNam.TabIndex = 1;
            this.cmbNam.Text = "Năm";
            // 
            // cmbQuy
            // 
            this.cmbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmbQuy.FormattingEnabled = true;
            this.cmbQuy.Location = new System.Drawing.Point(904, 90);
            this.cmbQuy.Name = "cmbQuy";
            this.cmbQuy.Size = new System.Drawing.Size(140, 37);
            this.cmbQuy.TabIndex = 2;
            this.cmbQuy.Text = "Quý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê số lượng học viên theo năm/quý";
            // 
            // fThongKeHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbQuy);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fThongKeHocVien";
            this.Text = "fThongKeHocVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbQuy;
        private System.Windows.Forms.Label label1;
    }
}