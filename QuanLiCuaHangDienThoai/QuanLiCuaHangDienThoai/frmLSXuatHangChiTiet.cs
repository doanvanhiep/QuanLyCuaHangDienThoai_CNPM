using BusinessLogicLayer;
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
    public partial class frmLSXuatHangChiTiet : Form
    {
        public int idhd;
        string error;
        HoaDonBLL hoadonbll;
        DataSet ds;
        public frmLSXuatHangChiTiet()
        {
            hoadonbll = new HoaDonBLL();
            ds = new DataSet();
            InitializeComponent();
        }

        private void frmLSXuatHangChiTiet_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            ds = hoadonbll.DSHDCT(ref error, idhd);
            dgvDSHoaDonChiTiet.DataSource = ds.Tables[0];
        }
    }
}
