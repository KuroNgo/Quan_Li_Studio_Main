using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmChinhSuaThongTin : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KRU45S6\MSSQLSERVER01;Initial Catalog=QuanLiStudio;Integrated Security=True");
        FrmThongTinDangNhap thongTinDangNhap = new FrmThongTinDangNhap();
        FrmQuanLi frmQuanLi = new FrmQuanLi();
        public FrmChinhSuaThongTin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = thongTinDangNhap.Email;
            txtSoDienThoai.Text = thongTinDangNhap.SDT;
            txtNgaySinh.Text = thongTinDangNhap.NgaySinh[0].ToString();
            txtTenTaiKhoan.Text = thongTinDangNhap.TenTaiKhoan;
            txtChucVu.Text = thongTinDangNhap.TenQuyenHan;
            txtCMND.Text = FrmDangNhap.SoCCCD;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Length > 0 && txtSoDienThoai.Text.Length > 0 && txtNgaySinh.Text.Length > 0 &&
                    txtTenTaiKhoan.Text.Length > 0 && txtDiaChi.Text.Length > 0
                    && txtChucVu.Text.Length > 0 && txtCMND.Text.Length > 0)
                {
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "UPDATE NhanVien " +
                        "SET SDT=@SDT,NgaySinh=@NgaySinh,Email=@Email,DiaChi=@DiaChi,SoCCCD=@SoCCCD Where ID=@ID";
                    sqlCommand.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text.ToString()));
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@SoCCCD", txtCMND.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@ID", frmQuanLi.UID);
                    sqlConnection.Open();
                    var soDong = sqlCommand.ExecuteNonQuery();
                    if (soDong > 0)
                    {
                        FrmThongTinDangNhap thongTinDangNhap = new FrmThongTinDangNhap();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        thongTinDangNhap.lblEmail.Text = Email;
                        thongTinDangNhap.lblSDT.Text = SDT;
                        thongTinDangNhap.lblNgaySinh.Text = NgaySinh;
                        thongTinDangNhap.lblTenTaiKhoan.Text = TenTaiKhoan;
                        thongTinDangNhap.lblChucVu.Text = ChucVuNhanVien;
                        thongTinDangNhap.lblCCCD.Text = SoCCCD;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                        this.Close();
                    }
                    sqlConnection.Close();

                }
                else
                {
                    FrmError warning = new FrmError();
                    warning.ShowDialog();
                }
            }
            catch (Exception)
            {

            }



        }
        private List<string> GetEmplyeeDetails(string iD)
        {
            List<string> strings = new List<string>();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT ur.*,nv.*,pms.TenQuyenHan " +
                "FROM  NhanVien nv, tbl_user ur,tbl_permission pms,tbl_per_relationship prl " +
                "WHERE  nv.ID=ur.MaNV and ur.ID=prl.id_user_rel and prl.id_per_rel=pms.id and ID = " + iD;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable("tbl_user");
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    var i8 = dr["TenTaiKhoan"].ToString();
                    var i = dr["TenNV"].ToString();
                    var i2 = dr["TenQuyenHan"].ToString();
                    var i3 = dr["SDT"].ToString();
                    var i4 = dr["NgaySinh"].ToString();
                    var i5 = dr["Email"].ToString();
                    var i6 = dr["DiaChi"].ToString();
                    var i7 = dr["SoCCCD"].ToString();
                    strings.Add(i);
                    strings.Add(i2);
                    strings.Add(i3);
                    strings.Add(i4);
                    strings.Add(i5);
                    strings.Add(i6);
                    strings.Add(i7);
                    strings.Add(i8);
                }
            }
            sqlConnection.Close();
            return strings;
        }

        private void GanThongTinVaoBien()
        {
            var list = GetEmplyeeDetails(frmQuanLi.UID);
            TenNhanVien = list[0];
            ChucVuNhanVien = list[1];
            SDT = list[2];
            NgaySinh = list[3];
            Email = list[4];
            DiaChi = list[5];
            SoCCCD = list[6];
            TenTaiKhoan = list[7];
        }
        public static string TenNhanVien = "";
        public static string ChucVuNhanVien = "";
        public static string SDT = "";
        public static string NgaySinh = "";
        public static string Email = "";
        public static string DiaChi = "";
        public static string SoCCCD = "";
        public static string TenTaiKhoan = "";

        private void btnRemoveLetter_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtNgaySinh.Text = "";
            txtTenTaiKhoan.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
        }
    }
}
