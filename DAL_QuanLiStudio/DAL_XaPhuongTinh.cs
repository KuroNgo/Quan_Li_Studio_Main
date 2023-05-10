using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLiStudio
{
    public class DAL_XaPhuongTinh : DAL_DBConnect
    {
        public DataTable getTinh()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TinhThanhPho ", _conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getHuyen(string maTinh)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * From QuanHuyen" +
                " where tinhThanhPhoID=" + maTinh, _conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable getXa(string maHuyen)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM XaPhuong " +
                "where QuanHuyenID =" + maHuyen, _conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    
    }
}
