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
    public class DangNhapBLL
    {
        DAL dal;
        public DangNhapBLL()
        {
            dal = new DAL();
        }
        //Hàm đăng nhập

        public DataSet DangNhap(ref string er, string userID, string password)
        {
            return dal.ExecuteQueryDataSet("spDangNhap", CommandType.StoredProcedure, ref er,
                new SqlParameter("@userID", userID), new SqlParameter("@password", password));
        }
    }
}
