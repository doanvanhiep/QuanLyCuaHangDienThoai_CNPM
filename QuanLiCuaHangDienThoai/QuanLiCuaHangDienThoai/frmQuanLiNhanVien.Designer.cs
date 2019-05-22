namespace QuanLiCuaHangDienThoai
{
    partial class frmQuanLiNhanVien
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
            this.dgvDanhsachSV = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSV)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhsachSV
            // 
            this.dgvDanhsachSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Ho,
            this.Ten,
            this.GioiTinh,
            this.QueQuan,
            this.TenLop});
            this.dgvDanhsachSV.Location = new System.Drawing.Point(12, 190);
            this.dgvDanhsachSV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhsachSV.Name = "dgvDanhsachSV";
            this.dgvDanhsachSV.RowTemplate.Height = 24;
            this.dgvDanhsachSV.Size = new System.Drawing.Size(664, 234);
            this.dgvDanhsachSV.TabIndex = 1212133;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.txtQuequan);
            this.panel.Controls.Add(this.txtMSSV);
            this.panel.Controls.Add(this.txtTen);
            this.panel.Controls.Add(this.txtHo);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(664, 159);
            this.panel.TabIndex = 1212134;
            this.panel.TabStop = false;
            this.panel.Text = "Thông tin";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(446, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(446, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuequan.Location = new System.Drawing.Point(446, 105);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(198, 20);
            this.txtQuequan.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(81, 37);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(186, 20);
            this.txtMSSV.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(80, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(186, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(81, 71);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(186, 20);
            this.txtHo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số ĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "ID";
            this.MaSV.Name = "MaSV";
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Tên";
            this.Ho.Name = "Ho";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Địa chỉ";
            this.Ten.Name = "Ten";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Email";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "CMND";
            this.QueQuan.Name = "QueQuan";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "MaLop";
            this.TenLop.HeaderText = "SĐT";
            this.TenLop.Name = "TenLop";
            this.TenLop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1212135;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(120, 447);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1212135;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(301, 447);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1212135;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(204, 447);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1212135;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(400, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1212135;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmQuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 497);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvDanhsachSV);
            this.Name = "frmQuanLiNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSV)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsachSV;
        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}