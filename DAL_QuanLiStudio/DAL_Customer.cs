using DTO_QuanLiStudio;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLiStudio
{
    public class DAL_Customer : DAL_DBConnect
    {
        #region Get Customer
        public DataTable getCustomer()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID,TenKH, CONCAT(Xa,',',Huyen,',',Tinh) as DiaChi,Email,SoDienThoai,enable FROM KhachHang Where Enable =1", _conn);
            DataTable dtCustomer = new DataTable();
            sqlDataAdapter.Fill(dtCustomer);
            return dtCustomer;
        }
        public DataTable getCustomer2()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID,TenKH, CONCAT(Xa,',',Huyen,',',Tinh) as DiaChi,Email,SoDienThoai,enable FROM KhachHang Where Enable =0", _conn);
            DataTable dtCustomer = new DataTable();
            sqlDataAdapter.Fill(dtCustomer);
            return dtCustomer;
        }
        #endregion
        #region Add 
        public bool Add_Customer(DTO_Customer ctm)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format($"INSERT INTO KhachHang(TenKH,SoDienThoai,Email,enable,Xa,Huyen,Tinh,Hinh) Values (N'{ctm.Customer_Name}',N'{ctm.Customer_Phone}',N'{ctm.Customer_Email}',{ctm.Customer_Enable},N'{ctm.Customer_Xa}',N'{ctm.Customer_Huyen}',N'{ctm.Customer_Tinh}',0)");
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    sqlTransaction.Commit();
                    return true;
                }
                else
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        #endregion
        #region Update
        public bool Update_Customer(DTO_Customer ctm)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE KhachHang SET TenKH=N'{0}',SoDienThoai='{1}',Email=N'{2}',Enable={3},Xa=N'{4}',Huyen=N'{5}',Tinh=N'{6}' WHERE ID={7}", ctm.Customer_Name, ctm.Customer_Phone, ctm.Customer_Email, ctm.Customer_Enable, ctm.Customer_Xa, ctm.Customer_Huyen, ctm.Customer_Tinh,ctm.Customer_ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    sqlTransaction.Commit();
                    return true;
                }
                else
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception)
            {
            }
            finally { _conn.Close(); }
            return false;
        }
        #endregion
        #region DELETE
        public bool Delete_Customer(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM KHACHHANG Where ID={0}  and Enable = 0 ", ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally { _conn.Close(); }
            return false;
        }
        #endregion
        #region DISABLE
        public bool Disable_Customer(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE KHACHHANG SET Enable =0 WHERE ID={0} and Enable =1", ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    sqlTransaction.Commit();
                    return true;
                }
                else
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception)
            {
            }
            finally { _conn.Close(); }
            return false;
        }
        #endregion
        #region Enable
        public bool Enable_Customer(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE KHACHHANG SET Enable =1 WHERE ID={0} and Enable =0", ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    sqlTransaction.Commit();
                    return true;
                }
                else
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception)
            {
            }
            finally { _conn.Close(); }
            return false;
        }
        #endregion
        public bool CheckExist(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * from KhachHang Where ID={0}", ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                int val = (int)sqlCommand.ExecuteScalar();
                if (val > 0)
                {
                    return true;
                }
               
            }
            catch (NullReferenceException)
            {

            }
            finally { _conn.Close(); }
            return false;
        }
    }
}
