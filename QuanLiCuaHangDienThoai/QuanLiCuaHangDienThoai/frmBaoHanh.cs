using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;


namespace QuanLiCuaHangDienThoai
{
    public partial class frmBaoHanh : Form
    {
        string error;
        SanPhamBLL spBLL;
        DataSet ds = new DataSet();
        public frmBaoHanh()
        {
            spBLL = new SanPhamBLL();
            InitializeComponent();
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            ds = spBLL.DSSanPhamBH(ref error);
            dgvDSBH.DataSource = ds.Tables[0];
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
