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
    public partial class frmMaMoi : Form
    {
        string error;
        SanPhamBLL bll;
        string file = "";
        OpenFileDialog ofdOpenFile;
        public frmMaMoi()
        {
            ofdOpenFile = new OpenFileDialog();
            InitializeComponent();
            bll = new SanPhamBLL();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpenFile.ShowDialog();
                 file = ofdOpenFile.FileName;
                if (string.IsNullOrEmpty(file))
                    return;
                picBoxSP.Image = Image.FromFile(@file);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn File dạng hình ảnh !!!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void frmMaMoi_Load(object sender, EventArgs e)
        {
            picBoxSP.Image = Image.FromFile(@"C:\Users\ADMIN\Pictures\Saved Pictures\x.jpg");
            picBoxSP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text;
            string mota = txtMoTa.Text;
            double gia = 0;
            if (txtGiaSP.Text.Trim()!="")
            {
                Convert.ToDouble(txtGiaSP.Text);
            }
            string hinh = file;
            int hanbaohanh =0;
            if (txtTGBH.Text.Trim()!="")
            {
                hanbaohanh = Convert.ToInt32(txtTGBH.Text);
            }

            bool kq= bll.ThemSanPham(tenSP, mota, gia, hinh, hanbaohanh, ref error);
            if(kq)
            {
                MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            
            else
            {
                this.Close();
                
                MessageBox.Show("Thêm thất bại !!!", "Lỗi", MessageBoxButtons.OK,
                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
