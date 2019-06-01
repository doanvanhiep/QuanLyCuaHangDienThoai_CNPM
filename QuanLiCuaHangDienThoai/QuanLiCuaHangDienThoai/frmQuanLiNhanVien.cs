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
    public partial class frmQuanLiNhanVien : Form
    {
        bool them = false;
        string error;
        Form f;
        NhanVienBLL nhanvienbll;
        DataSet dsnv;
        public frmQuanLiNhanVien(Form f)
        {
            nhanvienbll = new NhanVienBLL();
            dsnv = new DataSet();
            this.f = f;
            InitializeComponent();
        }

        

        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
        void loaddata()
        {
            dsnv = nhanvienbll.DSNhanVien(ref error);

            dgvDanhsachNV.DataSource = dsnv.Tables[0];

            dong();

            //databiding
            databiding();
        }

        void databiding()
        {
            txtID.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtSDT.DataBindings.Clear();

            txtID.DataBindings.Add("text", dsnv.Tables[0], "idNV", true, DataSourceUpdateMode.Never);
            txtTen.DataBindings.Add("text", dsnv.Tables[0], "tenNV", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("text", dsnv.Tables[0], "diachi", true, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("text", dsnv.Tables[0], "email", true, DataSourceUpdateMode.Never);
            txtCMND.DataBindings.Add("text", dsnv.Tables[0], "sochungminh", true, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("text", dsnv.Tables[0], "sdt", true, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtID.ResetText();
            txtTen.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtTen.Focus();
            txtTen.Enabled = true;
            dgvDanhsachNV.Enabled = false;

            mo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            mo();
            txtTen.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kt = false;
            bool ktcmnd = false;
            
            string tennv = txtTen.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cmndstr = txtCMND.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if(tennv=="")
            {
                MessageBox.Show("Vui lòng nhập tên", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtTen.Focus();

                
            }else
            {
                int cmnd=0;
                try
                {
                    cmnd = Convert.ToInt32(cmndstr);
                    ktcmnd = true;
                }catch
                {
                    ktcmnd = false;
                }
               if(ktcmnd)
                {
                    try
                    {
                        if (them)
                        {
                            kt = nhanvienbll.ThemNhanVien(ref error, tennv, diachi, email, cmnd, sdt);
                            if (kt)
                            {
                                MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }

                        }
                        else
                        {
                            int idnv = Convert.ToInt32(txtID.Text);
                            kt = nhanvienbll.SuaNhanVien(ref error, idnv, tennv, diachi, email, cmnd, sdt);
                            if (kt)
                            {
                                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                            }

                        }
                        dong();
                        loaddata();
                    }
                    catch (Exception)
                    {
                        this.Close();
                        f.Show();
                        MessageBox.Show("LỖI", "Lỗi", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }else
                {
                    txtCMND.ResetText();
                    txtCMND.Focus();
                    MessageBox.Show("Vui lòng nhập lại số chứng minh nhân dân cho đúng", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
               
            }

            dgvDanhsachNV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult tl = MessageBox.Show("Bạn có thật sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (tl == DialogResult.Yes)
                {
                    int idnv = Convert.ToInt32(txtID.Text);
                    bool kt = nhanvienbll.XoaNhanVien(ref error, idnv);
                    if (kt)
                    {
                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK,
                             MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK,
                              MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    loaddata();
                }
            }catch( Exception)
            {
                this.Close();
                f.Show();
                MessageBox.Show("LỖI", "Lỗi", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnThongtin.Enabled = false;
            databiding();
            dong();
            dgvDanhsachNV.Enabled = true;
        }

        void dong()
        {
            pnThongtin.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }
        void mo()
        {
            pnThongtin.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;

           
        }
    }

}
