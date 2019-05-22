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
    public partial class frmNhapHang : Form
    {
        Form f;
        public frmNhapHang(Form f)
        {
            this.f = f;
            InitializeComponent();
        }

        public frmNhapHang()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {

            f.Show();
            this.Close();
        }

        private void btnMaSPMoi_Click(object sender, EventArgs e)
        {
            frmMaMoi fmm = new frmMaMoi();
            fmm.ShowDialog();
        }

        private void btnThemCTy_Click(object sender, EventArgs e)
        {
            frmCongTy fct = new frmCongTy();
            fct.Show();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
