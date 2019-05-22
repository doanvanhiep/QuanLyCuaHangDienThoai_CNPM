﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangDienThoai
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void quétMãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Tính năng sẽ được update sau!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                , MessageBoxDefaultButton.Button1);
        }

        private void thủCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang(this);
            this.Hide();
            frmNhapHang.ShowDialog();
        }

        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatHang fxh = new frmXuatHang(this);
            this.Hide();
            fxh.ShowDialog();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiSanPham fqlsp = new frmQuanLiSanPham(this);
            this.Hide();
            fqlsp.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}