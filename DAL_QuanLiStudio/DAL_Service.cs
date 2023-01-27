using DTO_QuanLiStudio;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLiStudio
{
    public class DAL_Service : DAL_DBConnect
    {
        #region Get Information of Service
        public DataTable getService()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DichVu Where enable=1", _conn);
            DataTable dtService = new DataTable();
            sqlDataAdapter.Fill(dtService);
            return dtService;
        }

        public DataTable getCategoryService()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT DISTINCT LoaiGoiQuay FROM DichVu", _conn);
            DataTable dtCategoryService = new DataTable();
            sqlDataAdapter.Fill(dtCategoryService);
            return dtCategoryService;
        }

        public DataTable getServiceOfDisabled()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DichVu Where enable=0",_conn);
            DataTable dtServiceOfDisabled = new DataTable();
            sqlDataAdapter.Fill(dtServiceOfDisabled);
            return dtServiceOfDisabled;
        }

        #endregion
        #region Add Service
        public bool AddService(DTO_Service sv)
        {
            try
            {
                //Connect
                _conn.Open();
                //Query string
                string SQL = string.Format("INSERT INTO DICHVU(TenGoiQuay,LoaiGoiQuay,DonGia,SoNguoiQuay,MoTa,Enable) VALUES ('{0}',{1},{2},{3},'{4}',1)", sv.DichVu_Name, sv.DichVu_CategoryService, sv.DichVu_Price, sv.DichVu_PhotographerNumber, sv.DichVu_Content);
                //Command
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                //Query and check
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
        #region Update Service
        public bool UpdateService(DTO_Service sv)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE DICHVU SET TenGoiQuay='{0}',LoaiGoiQuay={1},DonGia={2},SoNguoiQuay={3},MoTa='{4}',Enable={5} WHERE ID={6}", sv.DichVu_Name, sv.DichVu_CategoryService, sv.DichVu_Price, sv.DichVu_PhotographerNumber, sv.DichVu_Content, sv.DichVu_Enable, sv.DichVu_ID);
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
        #region Delete Service
        public bool DeleteService(int Service_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM DICHVU WHERE ID={0} and Enable = 0", Service_ID);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Khi có nhiều dòng dữ liệu cần được chỉnh sửa,
                // nếu có quá trình thực hiện bị lỗi tại một dòng nào đó thì toàn bộ công việc chỉnh sửa coi như thất bại
                SqlTransaction sqlTransaction = _conn.BeginTransaction();
                cmd.Transaction = sqlTransaction;
                if (cmd.ExecuteNonQuery() > 0)
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
        #region Disable
        public bool Disable(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE DICHVU SET Enable=0 Where ID={0} and Enable =1",ID);
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
        #region Enable
        // Trường hợp dùng cho một đối tượng
        public bool Enable(int ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE DICHVU SET Enable=1 Where ID={0}", ID);
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
        #region Search
        //Used to Name_Service
        public bool SearchName(string text)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM DichVu Where TenGoiQuay like {0}", text);
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
       
        //Used to Price
        public bool SearchPrice(float num)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM DichVu Where DonGia={0}", num);
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

        public bool Search_PhotographerNumber(int num)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM DichVu Where SoNguoiQuay={0}", num);
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
        #region Check_exist
        public bool CheckExist(int ID)
        {
            try
            {
                 _conn.Open();
                string SQL = string.Format("SELECT * from DichVu Where ID={0}",ID);
                SqlCommand sqlCommand = new SqlCommand(SQL, _conn);
                int val=(int)sqlCommand.ExecuteScalar();
                if (val > 0)
                {
                    return true;
                }
                //else
                //{
                //    return false;
                //}
            }
            catch (NullReferenceException)
            {

            }
            finally { _conn.Close(); }
            return false;
        }
        #endregion
    }
}
