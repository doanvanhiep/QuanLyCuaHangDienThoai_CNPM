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
        DataSet dssptheoten = new DataSet();
        DataTable dssp = new DataTable();//table chứa danh sách sản phẩm
        public frmQuanLiSanPham(Form f)
        {
            this.f = f;
            InitializeComponent();
            bll = new SanPhamBLL();
            
        }
        void loadsp(DataSet datasp)
        {
            dssp = datasp.Tables[0];
            //Tính số dòng
            int sodong = Convert.ToInt32(Math.Ceiling((dssp.Rows.Count / 3.0)));
            CreatePicture(sodong, (dssp.Rows.Count % 3));
        }
        private void frmQuanLiSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                ds = bll.DSSanPham(ref error);//lấy ds sp từ database
                loadsp(ds);
            }
            catch
            {
               
            }
        }

        //hiển thị danh sách hình
        public void CreatePicture(int sodong,int kt)
        {
            panel23.Controls.Clear();
            panel23.Refresh();
            panel23.AutoScroll = true;

            int stt = 0;

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
                    pictureBox3.Name = stt.ToString();
                    pictureBox3.Location = new System.Drawing.Point(tamx, tamy);
                    pictureBox3.Size = new System.Drawing.Size(200, 200);
                    pictureBox3.TabIndex = 0;
                    pictureBox3.TabStop = false;
                    pictureBox3.Image = Image.FromFile(@dssp.Rows[stt]["hinh"].ToString());
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
                

                    Label t = new Label();
                    t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                 
                    t.Name = k.ToString();
                    t.Text=dssp.Rows[stt]["tenSP"].ToString();
                    t.Size = new System.Drawing.Size(200, 30);
                    t.Location = new System.Drawing.Point(tamx, tamy+210);
                    panel23.Controls.Add(pictureBox3);
                    panel23.Controls.Add(t);
                    tamx += 210;
                    stt++;
                }

                tamy += 240;
                tamx = x;
            }
            panel23.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            try
            {
                PictureBox p = (PictureBox)sender;
                frmChiTietSP f = new frmChiTietSP();
                f.dssp = dssp;
                f.stt = Convert.ToInt32(p.Name);
                f.ShowDialog();
                txtTimKiem.Text = " ";
            }
            catch
            {
                MessageBox.Show("LỖI", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
                f.Show();
            }
        }

        private void frmQuanLiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show(); 
        }
        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTimKiem.Text.Trim();
                if (ten == "")
                {
                    ds = bll.DSSanPham(ref error);//lấy ds sp từ database
                    loadsp(ds);
                }
                else
                {
                    dssptheoten = bll.DSSanPhamTheoTen(ref error, ten);//lấy ds sp từ database
                    loadsp(dssptheoten);
                }
              
            }
            catch
            {
                MessageBox.Show("LỖI", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
                f.Show();
            }
        }
    }
}
