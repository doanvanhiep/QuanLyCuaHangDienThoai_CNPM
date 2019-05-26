using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogicLayer
{
    public class KhoHangBLL
    {
        DAL dal;
        public KhoHangBLL()
        {
            dal = new DAL();
        }

        //Thêm kho hàng

        public bool ThemKhoHang(ref string error,int IDSP,int IDNV,double GiaNhap,DateTime NgayNhap,int SoLuong)
        {
            return dal.MyExecuteNonQuery("spThemKhoHang",CommandType.StoredProcedure,ref error,
                new SqlParameter("@IDSP",IDSP), new SqlParameter("@IDNV", IDNV),
                new SqlParameter("@GiaNhap", GiaNhap), new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@SoLuong", SoLuong));
        }

    }
}
