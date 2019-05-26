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
    public partial class frmQuanLiSanPham : Form
    {
        string error;// string Lỗi
        SanPhamBLL bll; 
        Form f;
        DataSet ds = new DataSet(); 
        DataTable dssp = new DataTable();//table chứa danh sách sản phẩm
        public frmQuanLiSanPham(Form f)
        {
            this.f = f;
            InitializeComponent();
            bll = new SanPhamBLL();
        }
        void loadsp()
        {
            ds = bll.DSSanPham(ref error);//lấy ds sp từ database
            dssp = ds.Tables[0];
            //Tính số dòng
            int sodong = Convert.ToInt32(Math.Ceiling((dssp.Rows.Count / 3.0)));
            CreatePicture(sodong, (dssp.Rows.Count % 3));
        }
        private void frmQuanLiSanPham_Load(object sender, EventArgs e)
        {
            loadsp();
        }

        //hiển thị danh sách hình
        public void CreatePicture(int sodong,int kt)
        {
            panel23.AutoScroll = true;
            int dem = sodong - 1;
            int so = 3;
            int x=30, y=16,tamx=x,tamy=y;
            for (int j = 0; j < sodong; j++)
            {
                //Tới dòng cuối kiểm tra xem số sản phẩm còn lại là bao nhiêu để in ra màn hình
                if(j==dem && kt!=0)
                {
                    so = kt;
                }
                for (int k = 0; k < so; k++)
                {
                    PictureBox pictureBox3 = new PictureBox();
                    pictureBox3.Name = k.ToString();
                    pictureBox3.Location = new System.Drawing.Point(tamx, tamy);
                    pictureBox3.Size = new System.Drawing.Size(200, 200);
                    pictureBox3.TabIndex = 0;
                    pictureBox3.TabStop = false;
                    pictureBox3.Image = Image.FromFile(@dssp.Rows[k]["hinh"].ToString());
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
            
            PictureBox p = (PictureBox)sender;
            frmChiTietSP f = new frmChiTietSP();
            f.dssp = dssp;
            f.stt =Convert.ToInt32(p.Name);
            f.ShowDialog();
            loadsp();
        }

        private void frmQuanLiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show(); 
        }
    }
}
