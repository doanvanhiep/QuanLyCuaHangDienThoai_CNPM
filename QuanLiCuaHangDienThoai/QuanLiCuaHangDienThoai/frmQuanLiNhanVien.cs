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
    public partial class frmQuanLiNhanVien : Form
    {
        Form f;
        public frmQuanLiNhanVien(Form f)
        {
            this.f = f;
            InitializeComponent();
        }

        

        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
    }
}
