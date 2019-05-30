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
    public partial class frmLSXuatHang : Form
    {
        string error;
        HoaDonBLL hoadonbll;
        DataSet ds;
        public frmLSXuatHang()
        {
            hoadonbll = new HoaDonBLL();
            ds = new DataSet();
            InitializeComponent();
        }

        private void frmLSXuatHang_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            ds = hoadonbll.DSHD(ref error);
            dgvDSHoaDon.DataSource =ds.Tables[0];
        }

        private void dgvDSHoaDon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                if (numrow + 1 > 0)
                {

                    frmLSXuatHangChiTiet f = new frmLSXuatHangChiTiet();
                    f.idhd = Convert.ToInt32(dgvDSHoaDon.Rows[numrow].Cells[0].Value.ToString());
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
