using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{

   public class SanPhamBLL
   {
        DAL dal;
        public SanPhamBLL()
        {
            dal = new DAL();
        }
        public DataSet DSSanPham(ref string error)
        {
            return dal.ExecuteQueryDataSet("spDSSP", CommandType.StoredProcedure, ref error);
        }

        public bool ThemSanPham(string TenSP,string MoTa,double GiaBan,string Hinh,int HanBaoHanh,ref string error)
        {
            return dal.MyExecuteNonQuery("spThemSP", CommandType.StoredProcedure, ref error,
                new SqlParameter("@TenSP", TenSP), new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@GiaBan", GiaBan), new SqlParameter("@Hinh", Hinh),
                new SqlParameter("@HanBaoHanh", HanBaoHanh));
        }

        public bool SuaSanPham(int IDSP,string TenSP, string MoTa, double GiaBan, int HanBaoHanh, ref string error)
        {
            return dal.MyExecuteNonQuery("spSuaSP", CommandType.StoredProcedure, ref error,
                new SqlParameter("@IDSP", IDSP),new SqlParameter("@TenSP", TenSP), 
                new SqlParameter("@MoTa", MoTa), new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@HanBaoHanh", HanBaoHanh));
        }
        //Update số lượng sản phẩm

        public bool SuaSLSP(ref string error,int IDSP,int SoLuong)
        {
            return dal.MyExecuteNonQuery("spSuaSLSP",CommandType.StoredProcedure,ref error,
                new SqlParameter("@IDSP",IDSP),new SqlParameter("@SoLuong",SoLuong));
        }
    }
}
