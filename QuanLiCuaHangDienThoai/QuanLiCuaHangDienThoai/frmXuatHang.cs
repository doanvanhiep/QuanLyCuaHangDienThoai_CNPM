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
    public partial class frmXuatHang : Form
    {
        Form f;
        public frmXuatHang(Form f)
        {
            this.f= f;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }
    }
}
