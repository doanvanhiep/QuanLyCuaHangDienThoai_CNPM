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
    public partial class frmMaMoi : Form
    {
        OpenFileDialog ofdOpenFile;
        public frmMaMoi()
        {
            ofdOpenFile = new OpenFileDialog();
            InitializeComponent();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpenFile.ShowDialog();
                string file = ofdOpenFile.FileName;
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
    }
}
