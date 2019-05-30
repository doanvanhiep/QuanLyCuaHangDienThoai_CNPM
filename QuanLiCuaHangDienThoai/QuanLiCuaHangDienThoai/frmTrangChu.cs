using System;
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
        public int idnv,quyen;
        public string mk;

        public string name = "";
        Form f;
        public frmTrangChu(Form f)
        {
            this.f = f;
            InitializeComponent();
        }

        

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Xin chào "+name;
            if(quyen!=1)
            {
                quảnLíNhânViênToolStripMenuItem.Enabled = false;
                danhSáchSảnPhẩmToolStripMenuItem.Enabled = false;
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.f1 = this;
            f.idnv = idnv;
            f.matkhau = mk;
            f.ShowDialog();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiNhanVien f = new frmQuanLiNhanVien(this);
            this.Hide();
            f.ShowDialog();
        }


        public void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dangxuat();
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiSanPham fqlsp = new frmQuanLiSanPham(this);
            this.Hide();
            fqlsp.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang(this);
            frmNhapHang.idnv = idnv;
            this.Hide();
            frmNhapHang.ShowDialog();
        }

      

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Xuất lịch sử
            frmLSXuatHang f = new frmLSXuatHang();

            f.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Xuất đơn
            frmXuatHang fxh = new frmXuatHang(this);
            fxh.idnv = idnv;
            this.Hide();
            fxh.ShowDialog();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaoHanh fbaohanh = new frmBaoHanh();
            fbaohanh.ShowDialog();
        }

        public void dangxuat()
        {
            Properties.Settings.Default.user = "";
            Properties.Settings.Default.pass = "";
            Properties.Settings.Default.check = false;
            Properties.Settings.Default.Save();
            this.Close();
            f.Show();
        }
    }
}
