using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLiStudio
{
    public class DAL_Staff:DAL_DBConnect
    {
        public DataTable getStaff()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM NhanVien Where enable=1", _conn);
            DataTable dtService = new DataTable();
            sqlDataAdapter.Fill(dtService);
            return dtService;
        }

    }
}
