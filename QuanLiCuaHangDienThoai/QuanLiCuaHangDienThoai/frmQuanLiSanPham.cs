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
    public partial class frmQuanLiSanPham : Form
    {
        Form f;
        public frmQuanLiSanPham(Form f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void frmQuanLiSanPham_Load(object sender, EventArgs e)
        {
            CreatePicture(3);
            //pictureBox1.Image = Image.FromFile(@"C:\Users\ADMIN\Pictures\Saved Pictures\x.jpg");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void CreatePicture(int i)
        {
            panel23.AutoScroll = true;
            int x=30, y=16,tamx=x,tamy=y;
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    PictureBox pictureBox3 = new PictureBox();
                    pictureBox3.Name = "pictureBox" +j.ToString()+ k.ToString();
                    pictureBox3.Location = new System.Drawing.Point(tamx, tamy);
                    pictureBox3.Size = new System.Drawing.Size(200, 200);
                    pictureBox3.TabIndex = 0;
                    pictureBox3.TabStop = false;
                    pictureBox3.Image = Image.FromFile(@"C:\Users\ADMIN\Pictures\Saved Pictures\x.jpg");
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
                    panel23.Controls.Add(pictureBox3);

                    tamx += 210;
                }

                tamy += 210;
                tamx = x;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmChiTietSP f = new frmChiTietSP();
            f.ShowDialog();
            PictureBox p =(PictureBox) sender;
            MessageBox.Show(p.Name);
        }

        private void frmQuanLiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }
    }
}
