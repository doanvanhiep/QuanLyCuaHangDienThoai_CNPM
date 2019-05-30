using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class NhanVienBLL
    {
        DAL dal;
        public NhanVienBLL()
        {
            dal = new DAL();
        }
        //lấy danh sách nhân viên

        public DataSet DSNhanVien(ref string error)
        {
            return dal.ExecuteQueryDataSet("spDSNhanVien", CommandType.StoredProcedure, ref error,null);
        }

        //Thêm Nhân viên

        public bool ThemNhanVien(ref string error,string TenNV,string DiaChi,string Email,int SoChungMinh,string SDT)
        {
            return dal.MyExecuteNonQuery("spThemNV",CommandType.StoredProcedure,ref error,
                new SqlParameter("@TenNV",TenNV), new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email), new SqlParameter("@SoChungMinh", SoChungMinh),
                new SqlParameter("@SDT", SDT));
        }

        //Sửa nhân viên
        public bool SuaNhanVien(ref string error,int IDNV, string TenNV, string DiaChi, string Email, int SoChungMinh, string SDT)
        {
            return dal.MyExecuteNonQuery("spSuaNV", CommandType.StoredProcedure, ref error, new SqlParameter("@IDNV", IDNV),
                new SqlParameter("@TenNV", TenNV), new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email), new SqlParameter("@SoChungMinh", SoChungMinh),
                new SqlParameter("@SDT", SDT));
        }

        // Xóa nhân viên
        public bool XoaNhanVien(ref string error, int IDNV)
        {
            return dal.MyExecuteNonQuery("spXoaNV", CommandType.StoredProcedure, ref error, new SqlParameter("@IDNV", IDNV));
        }

        //Đổi mật khẩu

        public bool DoiMK(ref string error, int IDNV,string MatKhau,string MatKhauMoi)
        {
            return dal.MyExecuteNonQuery("spDoiMK", CommandType.StoredProcedure, ref error, new SqlParameter("@IDNV", IDNV)
                , new SqlParameter("@MatKhau", MatKhau), new SqlParameter("@MatKhauMoi", MatKhauMoi));
        }
    }
}
