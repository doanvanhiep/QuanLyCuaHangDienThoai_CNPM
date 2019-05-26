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
    public partial class frmNhapHang : Form
    {
        public int idnv;
        string error;
        Form f;
        SanPhamBLL spbll;
        KhoHangBLL khbll;

        DataSet ds;
        public frmNhapHang(Form f)
        {
            spbll = new SanPhamBLL();
            khbll = new KhoHangBLL();
            ds = new DataSet();
            this.f = f;
            InitializeComponent();
        }

        public frmNhapHang()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {

            f.Show();
            this.Close();
        }

        private void btnMaSPMoi_Click(object sender, EventArgs e)
        {
            frmMaMoi fmm = new frmMaMoi();
            fmm.ShowDialog();
            load();
        }

      

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            ds = spbll.DSSanPham(ref error);
            cbxSP.DataSource = ds.Tables[0];
            cbxSP.DisplayMember = "tenSP";
            cbxSP.ValueMember = "idSP";
            cbxSP.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           try
            {
                int soluongdong = dgvSP.Rows.Count - 1;

                if(soluongdong>=0)
                {
                    for (int i = 0; i < soluongdong; i++)
                    {
                        khbll.ThemKhoHang(ref error, Convert.ToInt32(dgvSP.Rows[0].Cells[0].Value.ToString()), idnv,
                            Convert.ToDouble(dgvSP.Rows[0].Cells[3].Value.ToString()),
                            DateTime.Now, Convert.ToInt32(dgvSP.Rows[0].Cells[2].Value.ToString()));

                        spbll.SuaSLSP(ref error, Convert.ToInt32(dgvSP.Rows[0].Cells[0].Value.ToString()),
                            Convert.ToInt32(dgvSP.Rows[0].Cells[2].Value.ToString()));
                    }
                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK,
                              MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                this.Close();
                f.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
           try
            {
                if(txtSoLuong.Text.Trim().Equals("") || Convert.ToInt32(txtSoLuong.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Lỗi", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSoLuong.Focus();
                }
                else
                {
                    if (txtGiaNhap.Text.Trim().Equals("") || Convert.ToDouble(txtGiaNhap.Text.ToString()) <= 0 )
                    {
                        MessageBox.Show("Vui lòng nhập giá của sản phẩm", "Lỗi", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtGiaNhap.Focus();
                    }
                    else
                    {
                        dgvSP.Rows.Add(cbxSP.SelectedValue.ToString(), cbxSP.Text.ToString(),
                        txtSoLuong.Text.ToString(), txtGiaNhap.Text.ToString());
                       

                        txtSoLuong.ResetText();
                        txtGiaNhap.ResetText();
                        cbxSP.SelectedIndex = -1;
                    }
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Lỗi", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                load();
            }

            
        }
    }
}
