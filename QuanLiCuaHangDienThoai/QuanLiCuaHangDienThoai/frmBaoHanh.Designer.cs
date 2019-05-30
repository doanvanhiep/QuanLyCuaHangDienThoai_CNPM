namespace QuanLiCuaHangDienThoai
{
    partial class frmBaoHanh
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSBH = new System.Windows.Forms.DataGridView();
            this.idSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanbaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Danh Sách Các Sản Phẩm Còn Hạn Bảo Hành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBH);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 296);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvDSBH
            // 
            this.dgvDSBH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSP,
            this.tenSP,
            this.tenKH,
            this.hanbaohanh});
            this.dgvDSBH.Location = new System.Drawing.Point(6, 19);
            this.dgvDSBH.Name = "dgvDSBH";
            this.dgvDSBH.ReadOnly = true;
            this.dgvDSBH.Size = new System.Drawing.Size(595, 267);
            this.dgvDSBH.TabIndex = 1;
            // 
            // idSP
            // 
            this.idSP.DataPropertyName = "idSP";
            this.idSP.HeaderText = "IDSP";
            this.idSP.Name = "idSP";
            this.idSP.ReadOnly = true;
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên SP";
            this.tenSP.Name = "tenSP";
            this.tenSP.ReadOnly = true;
            this.tenSP.Width = 150;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "Tên Khách Hàng";
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            this.tenKH.Width = 150;
            // 
            // hanbaohanh
            // 
            this.hanbaohanh.DataPropertyName = "hanbaohanh";
            this.hanbaohanh.HeaderText = "Hạn Bảo Hành";
            this.hanbaohanh.Name = "hanbaohanh";
            this.hanbaohanh.ReadOnly = true;
            this.hanbaohanh.Width = 150;
            // 
            // frmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo Hành";
            this.Load += new System.EventHandler(this.frmBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanbaohanh;
    }
}