using System.Data.SqlClient;

namespace DAL_QuanLiStudio
{
    public class DAL_DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-KRU45S6\MSSQLSERVER01;Initial Catalog=QuanLiStudio4;Integrated Security=True");
    }
}
