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
    public partial class frmChiTietSP : Form
    {
        string error="";
        SanPhamBLL bll;
        public DataTable dssp;
        public int stt = 0;
        public frmChiTietSP()
        {
            bll = new SanPhamBLL();
            InitializeComponent();
            
        }

        private void frmChiTietSP_Load(object sender, EventArgs e)
        {
            txtTen.Text = dssp.Rows[stt]["tenSP"].ToString();
            txtMota.Text = dssp.Rows[stt]["mota"].ToString();
            txtGiaBan.Text = dssp.Rows[stt]["giaban"].ToString();
            hinhanh.Image = Image.FromFile(@dssp.Rows[stt]["hinh"].ToString());
            txtBH.Text = dssp.Rows[stt]["hanbaohanh"].ToString();
            txtTongso.Text = dssp.Rows[stt]["tongsoluong"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int idsp= Convert.ToInt32(dssp.Rows[stt]["idSP"].ToString());
            double giaban=0;
            int hanbaohanh=0;

            if(txtGiaBan.Text.Trim() != "")
            {
                giaban = Convert.ToDouble(txtGiaBan.Text.Trim());
            }
            if(txtBH.Text.Trim()!="")
            {
                hanbaohanh = Convert.ToInt32(txtBH.Text.Trim());
            }
            
            bool kq = bll.SuaSanPham(idsp, txtTen.Text, txtMota.Text,giaban,hanbaohanh, ref error);
            if (kq)
            {
                MessageBox.Show("Đã sửa thành công!!!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Sửa thất bại !!!", "Lỗi", MessageBoxButtons.OK,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

    
    }
}
