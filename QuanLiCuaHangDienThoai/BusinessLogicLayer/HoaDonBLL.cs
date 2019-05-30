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
   public class HoaDonBLL
    {
        DAL dal;
        public HoaDonBLL()
        {
            dal = new DAL();
        }
        public bool ThemHoaDon(ref string error,int IDKH,int IDNV,double TongTien,DateTime NgayXuat)
        {
            return dal.MyExecuteNonQuery("spThemHoaDon", CommandType.StoredProcedure, ref error,
                new SqlParameter("@IDKH", IDKH), new SqlParameter("@IDNV", IDNV),
                 new SqlParameter("@TongTien", TongTien), new SqlParameter("@NgayXuat", NgayXuat));
        }

        public bool ThemCTHoaDon(ref string error, int IDSP, int SoLuong, double DonGia)
        {
            return dal.MyExecuteNonQuery("spThemHoaDonChiTiet", CommandType.StoredProcedure, ref error,
                new SqlParameter("@IDSP", IDSP), new SqlParameter("@SoLuong", SoLuong),
                 new SqlParameter("@DonGia", DonGia));
        }
        //Danh sách hóa đơn 

        public DataSet DSHD (ref string error)
        {
            return dal.ExecuteQueryDataSet("spDSHD", CommandType.StoredProcedure, ref error);
        }

        public DataSet DSHDCT(ref string error, int IDHD)
        {
            return dal.ExecuteQueryDataSet("spHDCTbyID", CommandType.StoredProcedure, ref error,new SqlParameter("@IDHD",IDHD));
        }
    }
}
