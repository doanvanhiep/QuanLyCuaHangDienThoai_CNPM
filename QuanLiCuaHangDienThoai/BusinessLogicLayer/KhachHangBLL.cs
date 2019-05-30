using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
   public class KhachHangBLL
    {
        DAL dal;
        public KhachHangBLL()
        {
            dal = new DAL();

        }

        public DataSet TimKhachHang(ref string error,string sdt)
        {
            return dal.ExecuteQueryDataSet("spTimKHangtheoSDT",CommandType.StoredProcedure,ref error,
                new SqlParameter("@SDT",sdt));
        }

        public bool ThemKhachHang(ref string error, string sdt,string tenKH,string diachi)
        {
            return dal.MyExecuteNonQuery("spThemKhachHang", CommandType.StoredProcedure, ref error,
                new SqlParameter("@SDT", sdt), new SqlParameter("@DiaChi", diachi), new SqlParameter("@TenKH",tenKH));
        }

       
    }
}
