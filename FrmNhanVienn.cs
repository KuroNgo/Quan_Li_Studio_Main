using BUS_QuanLiStudio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmNhanVienn : Form
    {
        BUS_Staff bus_Staff = new BUS_Staff();
        string connectionString = @"Data Source=DESKTOP-KRU45S6\MSSQLSERVER01;Initial Catalog=QuanLiStudio4;Integrated Security=True";
        public int maEnable = 0;
        public FrmNhanVienn()
        {
            InitializeComponent();
            dtgvDanhSachNhanVien.AutoGenerateColumns = false;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frmThemNhanVien = new FrmThemNhanVien();
            frmThemNhanVien.ShowDialog();

        }
        public void LoadAllData()
        {
            //dtgvDanhSachNhanVien.DataSource=bus_Staff
            lblCount.Text = dtgvDanhSachNhanVien.RowCount.ToString() + " nhân viên";
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            LoadAllData();
            txtTimKiem.Text = "";
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
            //pnExClamration.Visible = false;
        }



        private void dtgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                FrmWarning frmHoiThongTin = new FrmWarning();
                frmHoiThongTin.ShowDialog();
                if (frmHoiThongTin.btnAgree.Checked == true)
                {
                    if (this.dtgvDanhSachNhanVien[7, e.RowIndex].Value.ToString() == "admin")
                    {
                        this.dtgvDanhSachNhanVien.CancelEdit();
                        MessageBox.Show("Không thể thay đổi người có chức vụ quản trị viên");
                    }
                    // Dùng để bắt ngoại lệ khi xảy ra lỗi ( ở đây là khi chọn vào Dòng header )
                    try
                    {

                        var ma = int.Parse(this.dtgvDanhSachNhanVien[0, e.RowIndex].Value.ToString());
                        int enable;
                        if (int.Parse(this.dtgvDanhSachNhanVien[8, e.RowIndex].Value.ToString()) == 1)
                        {
                            enable = 0;
                        }
                        else
                            enable = 1;
                        SqlConnection sqlConnection = new SqlConnection(connectionString);
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandText = "UPDATE NhanVien SET enable=@enable where ID=@ID";

                        sqlCommand.Parameters.AddWithValue("@ID", ma);
                        sqlCommand.Parameters.AddWithValue("@enable", enable);


                        sqlConnection.Open();
                        var soDong = sqlCommand.ExecuteNonQuery();

                        if (soDong > 0)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            maEnable = enable;
                            DialogResult = DialogResult.OK;
                        }
                        else
                            MessageBox.Show("Cập nhật thất bại");

                        sqlConnection.Close();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Không hợp lệ!", "Thông báo", MessageBoxButtons.YesNo);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OKCancel);
                    }
                }
                else
                    dtgvDanhSachNhanVien.CancelEdit();
            }
        }

        private void btnExClamation_Click(object sender, EventArgs e)
        {
            //    if (btnExClamation.Checked == true)
            //    {
            //        pnExClamration.Visible = true;
            //    }
            //    else
            //        pnExClamration.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmSettingAccountAndViewAccount frmSettingAccountAndViewAccount = new FrmSettingAccountAndViewAccount();
            frmSettingAccountAndViewAccount.ShowDialog();
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string vb = txtTimKiem.Text;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT nv.*,ur.TenTaiKhoan,pms.TenQuyenHan " +
               "FROM NhanVien nv, tbl_user ur,tbl_permission pms,tbl_per_relationship prl " +
               "Where nv.ID=ur.MaNV and " +
               "ur.ID=prl.id_user_rel and " +
               "prl.id_per_rel=pms.id and TenNV like N'%" + vb + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable("NhanVien");

                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();

                dtgvDanhSachNhanVien.DataSource = dataTable;
                lblCount.Text = dtgvDanhSachNhanVien.RowCount.ToString() + " nhân viên";
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi!");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
    }
}
