
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
            this.cmbTenChungChi = new System.Windows.Forms.ComboBox();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHienToanBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDiaDiem
            // 
            this.cmbDiaDiem.FormattingEnabled = true;
            this.cmbDiaDiem.Location = new System.Drawing.Point(715, 119);
            this.cmbDiaDiem.Margin = new System.Windows.Forms.Padding(6);
            this.cmbDiaDiem.Name = "cmbDiaDiem";
            this.cmbDiaDiem.Size = new System.Drawing.Size(303, 33);
            this.cmbDiaDiem.TabIndex = 23;
            this.cmbDiaDiem.Text = "Địa Điểm";
            this.cmbDiaDiem.SelectedIndexChanged += new System.EventHandler(this.cmbDiaDiem_SelectedIndexChanged);
            // 
            // cmbTenChungChi
            // 
            this.cmbTenChungChi.FormattingEnabled = true;
            this.cmbTenChungChi.Location = new System.Drawing.Point(190, 124);
            this.cmbTenChungChi.Margin = new System.Windows.Forms.Padding(6);
            this.cmbTenChungChi.Name = "cmbTenChungChi";
            this.cmbTenChungChi.Size = new System.Drawing.Size(290, 33);
            this.cmbTenChungChi.TabIndex = 22;
            this.cmbTenChungChi.Text = "Tên chứng chỉ";
            this.cmbTenChungChi.SelectedIndexChanged += new System.EventHandler(this.cmbTenChungChi_SelectedIndexChanged);
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Location = new System.Drawing.Point(37, 179);
            this.dgvLichThi.Margin = new System.Windows.Forms.Padding(6);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.RowHeadersWidth = 82;
            this.dgvLichThi.Size = new System.Drawing.Size(981, 446);
            this.dgvLichThi.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 73);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lịch Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(31, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chứng chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(583, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa điểm";
            // 
            // btnHienToanBo
            // 
            this.btnHienToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHienToanBo.Location = new System.Drawing.Point(410, 643);
            this.btnHienToanBo.Name = "btnHienToanBo";
            this.btnHienToanBo.Size = new System.Drawing.Size(261, 48);
            this.btnHienToanBo.TabIndex = 26;
            this.btnHienToanBo.Text = "Hiện toàn bộ";
            this.btnHienToanBo.UseVisualStyleBackColor = true;
            this.btnHienToanBo.Click += new System.EventHandler(this.btnHienToanBo_Click);
            // 
            // fXemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 713);
            this.Controls.Add(this.btnHienToanBo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDiaDiem);
            this.Controls.Add(this.cmbTenChungChi);
            this.Controls.Add(this.dgvLichThi);
            this.Controls.Add(this.label1);
            this.Name = "fXemLichThi";
            this.Text = "Lịch thi";
            this.Load += new System.EventHandler(this.fXemLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiaDiem;
        private System.Windows.Forms.ComboBox cmbTenChungChi;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHienToanBo;
    }
}