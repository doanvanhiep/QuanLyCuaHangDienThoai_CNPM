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
    public partial class frmXuatHang : Form
    {
        public int idnv;
        int idkh;
        string error;
        Form f;
        DataSet ds,dsspid,dskh;
        SanPhamBLL spbll;
        KhachHangBLL khachhangbll;
        HoaDonBLL hoadonBLL;
        int tongsoluongconlai = 0;
        //Kiểm tra xem khách hàng đã tồn tại chưa
        double tongtien=0;

        bool ktkh = false;
       
        public frmXuatHang(Form f)
        {
            spbll = new SanPhamBLL();
            ds = new DataSet();
            dsspid = new DataSet();
            dskh = new DataSet();
            khachhangbll = new KhachHangBLL();
            hoadonBLL = new HoaDonBLL();
            this.f= f;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        private void cbxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                string a = cbxTenSP.SelectedValue.ToString();
                int IDSP = Convert.ToInt32(a);
                dsspid = spbll.TimSPTheoID(ref error, IDSP);
                txtHBH.Text = dsspid.Tables[0].Rows[0]["hanbaohanh"].ToString();
                txtDonGia.Text = dsspid.Tables[0].Rows[0]["giaban"].ToString();
                tongsoluongconlai = Convert.ToInt32(dsspid.Tables[0].Rows[0]["tongsoluong"].ToString());
            }
            catch(Exception)
            {

            }

        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSL.Text.Trim().Equals("") || Convert.ToInt32(txtSL.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSL.Focus();
                }
                else
                {
                   
                    if (Convert.ToInt32(txtSL.Text)>tongsoluongconlai)
                    {
                        MessageBox.Show("Sản phẩm trong khi hiện chỉ còn "+tongsoluongconlai, "Lỗi", MessageBoxButtons.OK,
                       MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtSL.Focus();
                    }
                    else
                    {
                        dgvSP.Rows.Add(cbxTenSP.SelectedValue.ToString(), cbxTenSP.Text.ToString(),
                         txtSL.Text.ToString(), txtDonGia.Text.ToString(), txtHBH.Text.ToString());

                        tongtien += Convert.ToDouble(txtDonGia.Text) * Convert.ToInt32(txtSL.Text);

                        txtTongTien.Text = tongtien.ToString();

                        txtSL.ResetText();
                        txtDonGia.ResetText();
                        txtHBH.ResetText();
                        cbxTenSP.SelectedIndex = -1;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Lỗi", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSL.ResetText();
                load();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(txtSDT.Text.Length==10)
            {
                dskh = khachhangbll.TimKhachHang(ref error, txtSDT.Text);
                if(dskh.Tables[0].Rows.Count!=0)
                {
                    txtHoTen.Text = dskh.Tables[0].Rows[0]["tenKH"].ToString();
                    txtDiaChi.Text = dskh.Tables[0].Rows[0]["diachi"].ToString();
                    idkh=Convert.ToInt32(dskh.Tables[0].Rows[0]["idKH"].ToString());
                    ktkh = true;
                }
                else
                {
                    ktkh = false;
                }
            }
            else
            {
                txtDiaChi.ResetText();
                txtHoTen.ResetText();
                ktkh = false;
            }
        }

        //Kiểm tra xem hàm thông tin khách hàng có đủ chưa
         bool ttkh()
        {
            if(txtSDT.Text.Trim().Equals("")|| txtSDT.Text.Length!=10
                || txtHoTen.Text.Trim().Equals("")
                || txtDiaChi.Text.Trim().Equals(""))
            {
                return false;
            }
            return true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                int sodong = dgvSP.Rows.Count-1;
                if (ttkh() && sodong > 0)
                {
                    if (!ktkh)
                    {
                        khachhangbll.ThemKhachHang(ref error, txtSDT.Text, txtHoTen.Text, txtDiaChi.Text);

                        dskh = khachhangbll.TimKhachHang(ref error, txtSDT.Text);
                        idkh = Convert.ToInt32(dskh.Tables[0].Rows[0]["idKH"].ToString());
                    }
                    //insert hóa đơn

                    hoadonBLL.ThemHoaDon(ref error, idkh, idnv, Convert.ToDouble(txtTongTien.Text), DateTime.Now);

                    //Insert Hóa Đơn chi tiết
                  

                    for(int i=0;i<sodong;i++)
                    {
                        int idsp = Convert.ToInt32(dgvSP.Rows[i].Cells[0].Value.ToString());
                        int soluongsp = Convert.ToInt32(dgvSP.Rows[i].Cells[2].Value.ToString());
                        double dongia = Convert.ToDouble(dgvSP.Rows[i].Cells[3].Value.ToString());

                        //Thêm hóa đơn chi tiết
                        hoadonBLL.ThemCTHoaDon(ref error, idsp,soluongsp, dongia);
                        //Trừ trong kho
                        spbll.SuaSLSP(ref error, idsp, soluongsp * -1);
                        //Nếu hạn bảo hành lớn không
                        if (Convert.ToInt32(dgvSP.Rows[i].Cells[4].Value.ToString())>0)
                        {
                            //Thêm bảo hành
                            spbll.ThemBaoHanh(ref error,idsp, idkh,
                                GetDate(Convert.ToInt32(dgvSP.Rows[i].Cells[4].Value.ToString())));
                        }
                    }
                    MessageBox.Show("Xuất hàng thành công", "Thông báo", MessageBoxButtons.OK,
                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại thông tin khách hàng hoặc đơn hàng rỗng", "Lỗi", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }catch(Exception excep)
            {
                MessageBox.Show(excep.ToString(), "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        void load()
        {
            ds = spbll.DSSanPham(ref error);
            cbxTenSP.DataSource = ds.Tables[0];
            cbxTenSP.DisplayMember = "tenSP";
            cbxTenSP.ValueMember = "idSP";
            cbxTenSP.SelectedIndex = -1;
            txtTongTien.Text = tongtien.ToString();
        }


        DateTime GetDate(int thang)
        {
            bool ktnn = false;
            DateTime dateTime = DateTime.Now;

            int year = dateTime.Year;
            int month = dateTime.Month +thang;
            int day = dateTime.Day;

           year += (month / 12);
           month = month % 12;

            if (month==0)
            {
                year -= 1;
                month = 12;
            }
           if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                ktnn = true;
            }
            if (day>28 && month==2)
            {
                if(!ktnn)
                {
                    month += 1;
                    day -= 28;
                }
                else
                {
                    if(day>29)
                    {
                        month += 1;
                        day -= 29;
                    }
                }
            }
            

            DateTime kq= new DateTime(year, month, day);
            return kq;
        }
    }
}
