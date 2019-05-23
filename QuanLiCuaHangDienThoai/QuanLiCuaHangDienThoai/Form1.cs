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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmTrangChu frmTrangChu = new frmTrangChu();
            this.Hide();
            frmTrangChu.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có thực sự muốn thoát không??", "Thông báo", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if(tl==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
