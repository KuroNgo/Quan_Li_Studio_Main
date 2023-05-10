using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmDangNhap : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KRU45S6\MSSQLSERVER01;Initial Catalog=QuanLiStudio4;Integrated Security=True");
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (btnShowPass.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.Image = Image.FromFile(@"D:\QuanLiStudio2\QuanLiStudio2\Picture\view.png");
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.Image = Image.FromFile(@"D:\QuanLiStudio2\QuanLiStudio2\Picture\visibility (1).png");
            }
        }
        #region Code Đăng nhập

        private string getID(string user_name, string password)
        {
            string id = "";
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT ur.* " +
                    "FROM tbl_user ur,NhanVien nv " +
                    "WHERE nv.enable =1 and tentaikhoan = '" + user_name + "' and pass= '" + password + " '";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable("tbl_user");
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        id = dr["id"].ToString();
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                lblKiemTraTaiKhoan.Visible = true;
            }
            return id;
        }

        private List<string> GetEmplyeeDetails(string user_name, string password)
        {
            List<string> strings = new List<string>();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT ur.*,nv.*,pms.TenQuyenHan " +
                "FROM  NhanVien nv, tbl_user ur,tbl_permission pms,tbl_per_relationship prl " +
                "WHERE  nv.ID=ur.MaNV and ur.ID=prl.id_user_rel and prl.id_per_rel=pms.id and tentaikhoan = '" + user_name + "' and pass= '" + password + " '";
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
                    var i7 = dr["SoCCCD"].ToString();
                    strings.Add(i);
                    strings.Add(i2);
                    strings.Add(i3);
                    strings.Add(i4);
                    strings.Add(i5);
                    //strings.Add(i6);
                    strings.Add(i7);
                    strings.Add(i8);
                }
            }
            sqlConnection.Close();
            return strings;
        }

        private void GanThongTinVaoBien()
        {
            //var list = GetEmplyeeDetails(txtUsername.Text, txtPassword.Text);
            //TenNhanVien = list[0];
            //ChucVuNhanVien = list[1];
            //SDT = list[2];
            //NgaySinh = list[3];
            //Email = list[4];
            ////DiaChi = list[5];
            //SoCCCD = list[6];
            //TenTaiKhoan = list[7];
        }

        public static string ID_USER = "";
        public static string TenNhanVien = "";
        public static string ChucVuNhanVien = "";
        public static string SDT = "";
        public static string NgaySinh = "";
        public static string Email = "";
        //public static string DiaChi = "";
        public static string SoCCCD = "";
        public static string TenTaiKhoan = "";

        #endregion
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            lblKiemTraTaiKhoan.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            ID_USER = getID(txtUsername.Text, txtPassword.Text);

            if (ID_USER != "")
            {
                this.Hide();
                GanThongTinVaoBien();
                
                FrmQuanLi frmQuanLi = new FrmQuanLi();
                frmQuanLi.Show();
                FrmToastMessage frm = new FrmToastMessage();
                frm.showAlert();
            }
            else
            {
                lblKiemTraTaiKhoan.Visible = true;
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác số và khác chữ => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46|| e.KeyChar == 8||e.KeyChar==162)
                e.Handled = false;
          
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác số và khác chữ => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46)
                e.Handled = true;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
