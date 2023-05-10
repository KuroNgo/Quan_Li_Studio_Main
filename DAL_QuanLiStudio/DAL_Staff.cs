using DTO_QuanLiStudio;
using System;
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
        public DataTable getStaff2()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM NhanVien Where Enable =0", _conn);
            DataTable dtStaff = new DataTable();
            sqlDataAdapter.Fill(dtStaff);
            return  dtStaff;
        }
        public DataTable getStaffForAccount()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT nv.*, ur.TenTaiKhoan, pms.TenQuyenHan " +
                "FROM NhanVien nv, tbl_user ur,tbl_permission pms,tbl_per_relationship prl " +
                "Where nv.ID=ur.MaNV and " +
                "ur.ID=prl.id_user_rel and " +
                "prl.id_per_rel=pms.id" + " and ur.TenTaiKhoan not like N'% admin %'", _conn);
            DataTable dataTable= new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        #region Add 
        public bool Add_Staff(DTO_Staff stf)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format($"INSERT INTO NhanVien(TenNV,SDT,NgaySinh,Email,SoCCCD,enable,Xa,Huyen,Tinh,Hinh) Values (N'{stf.Staff_NameST}',N'{stf.Staff_Phone}','{stf.DateTime_Staff_Date}',{stf.Staff_Email},N'{stf.Staff_SoCCCD}',N'{stf.Staff_enable}',N'{stf.Staff_Xa}',N'{stf.Staff_Huyen}',N'{stf.Staff_Tinh}',0)");
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
        public bool Update_Staff(DTO_Staff stf)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NhanVien SET TenNV=N'{0}',SDT='{1}',NgaySinh='{2}',Email=N'{3}',SoCCCD='{4}',Enable={5},Xa=N'{6}',Huyen=N'{7}',Tinh=N'{8}' WHERE ID={9}",stf.Staff_NameST,stf.Staff_Phone
                ,stf.DateTime_Staff_Date,stf.Staff_Email,stf.Staff_SoCCCD,stf.Staff_enable,stf.Staff_Xa,stf.Staff_Huyen, stf.Staff_Tinh,stf.Staff_ID);
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
        public bool Delete_Staff(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM NhanVien Where ID={0}  and Enable = 0 ", ID);
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
        public bool Disable_Staff(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NhanVien SET Enable =0 WHERE ID={0} and Enable =1", ID);
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
        public bool Enable_Staff(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NhanVien SET Enable =1 WHERE ID={0} and Enable =0", ID);
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
                string SQL = string.Format("SELECT * from NhanVien Where ID={0}", ID);
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
