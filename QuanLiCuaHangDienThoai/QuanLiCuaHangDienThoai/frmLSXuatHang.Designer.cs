namespace QuanLiCuaHangDienThoai
{
    partial class frmLSXuatHang
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
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.idHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Danh Sách Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 296);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHD,
            this.ngayxuat,
            this.tenNV,
            this.tongtien,
            this.tenKH});
            this.dgvDSHoaDon.Location = new System.Drawing.Point(6, 19);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.ReadOnly = true;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(655, 267);
            this.dgvDSHoaDon.TabIndex = 1;
            this.dgvDSHoaDon.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDon_CellContentDoubleClick);
            // 
            // idHD
            // 
            this.idHD.DataPropertyName = "idHD";
            this.idHD.HeaderText = "ID";
            this.idHD.Name = "idHD";
            this.idHD.ReadOnly = true;
            this.idHD.Width = 50;
            // 
            // ngayxuat
            // 
            this.ngayxuat.DataPropertyName = "ngayxuat";
            this.ngayxuat.HeaderText = "Ngày Xuất";
            this.ngayxuat.Name = "ngayxuat";
            this.ngayxuat.ReadOnly = true;
            this.ngayxuat.Width = 150;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "tenNV";
            this.tenNV.HeaderText = "Tên NV";
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            this.tenNV.Width = 130;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 130;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "Tên KH";
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            this.tenKH.Width = 150;
            // 
            // frmLSXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLSXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Xuất Hàng";
            this.Load += new System.EventHandler(this.frmLSXuatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
    }
}