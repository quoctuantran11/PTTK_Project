
namespace PTTK_Project
{
    partial class fXemLichThi
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
            this.cmbDiaDiem = new System.Windows.Forms.ComboBox();
            this.cmbNgayThi = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDiaDiem
            // 
            this.cmbDiaDiem.FormattingEnabled = true;
            this.cmbDiaDiem.Location = new System.Drawing.Point(933, 134);
            this.cmbDiaDiem.Margin = new System.Windows.Forms.Padding(6);
            this.cmbDiaDiem.Name = "cmbDiaDiem";
            this.cmbDiaDiem.Size = new System.Drawing.Size(222, 33);
            this.cmbDiaDiem.TabIndex = 23;
            this.cmbDiaDiem.Text = "Địa Điểm";
            // 
            // cmbNgayThi
            // 
            this.cmbNgayThi.FormattingEnabled = true;
            this.cmbNgayThi.Location = new System.Drawing.Point(589, 134);
            this.cmbNgayThi.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNgayThi.Name = "cmbNgayThi";
            this.cmbNgayThi.Size = new System.Drawing.Size(290, 33);
            this.cmbNgayThi.TabIndex = 22;
            this.cmbNgayThi.Text = "Tên chứng chỉ";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 179);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(1118, 446);
            this.dataGridView.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 73);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lịch Thi";
            // 
            // fXemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 661);
            this.Controls.Add(this.cmbDiaDiem);
            this.Controls.Add(this.cmbNgayThi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "fXemLichThi";
            this.Text = "Lịch thi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiaDiem;
        private System.Windows.Forms.ComboBox cmbNgayThi;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}