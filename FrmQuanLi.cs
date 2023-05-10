using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLiStudio2
{
    public partial class FrmQuanLi : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KRU45S6\MSSQLSERVER01;Initial Catalog=QuanLiStudio4;Integrated Security=True");
        public string UID = FrmDangNhap.ID_USER;
        string TenNV = FrmDangNhap.TenNhanVien;
        string TenChucVu = FrmDangNhap.ChucVuNhanVien;
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlink.Controls.Add(childForm);
            pnlink.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public FrmQuanLi()
        {

            ////Flash Screen 
            FrmGioiThieu frmGioiThieu = new FrmGioiThieu();
            frmGioiThieu.ShowDialog();
            InitializeComponent();
           
        }
        List<string> list_per = null;
        private void FrmQuanLi_Load(object sender, EventArgs e)
        {
           
            //// Kích thước to khi load form
            //btnMaximize.Enabled=false;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            //btnMaximize.Image = Image.FromFile(@"D:\QuanLiStudio2\QuanLiStudio2\Picture\squares.png");

            lblChucVu.Text = TenChucVu;
            lblTenNhanVien.Text = TenNV;
            list_per = List_per();
            if (checkper("Statistical") == true)
            {
                OpenChildForm(new TongQuat());
                btnTongQuan.Checked = true;
            }
            else
            {
                btnTongQuan.Visible = false;
            }
            if (checkper("STAFF") == false)
            {
                btnNhanVien.Visible = false;
            }
            if (checkper("BILL") == false)
            {
                btnHoaDon.Visible = false;
            }
            if (checkper("CUSTOMER") == false)
            {
                btnKhachHang.Visible = false;
            }
            if (checkper("SERVICE") == false)
            {
                btnDichVu.Visible = false;
            }
        }


        private bool checkper(string code)
        {
            bool check = false;
            foreach (string item in list_per)
            {
                if (item == code)
                {
                    check = true;
                    break;
                }
                else
                    check = false;
            }
            return check;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //if (btnMaximize.Checked == true)
            //{
            //    MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //    WindowState = FormWindowState.Normal;
            //    btnMaximize.Image = Image.FromFile(@"D:\QuanLiStudio2\QuanLiStudio2\Picture\maximize.png");
            //    guna2HtmlToolTip1.SetToolTip(btnMaximize, "Phóng to");
            //}
            //else
            //{
            //    MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //    WindowState = FormWindowState.Maximized;
            //    btnMaximize.Image = Image.FromFile(@"D:\QuanLiStudio2\QuanLiStudio2\Picture\squares.png");
            //    guna2HtmlToolTip1.SetToolTip(btnMaximize, "Thu nhỏ");
            //}
            //btnMaximize.Enabled=false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Minimized;
            //guna2HtmlToolTip1.SetToolTip(btnMaximize, "Ẩn");
        }


        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            if (checkper("Statistical") == true)
            {
                OpenChildForm(new TongQuat());
            }
            else
            {
                FrmError warning = new FrmError();
                warning.Show();
                btnTongQuan.Checked = false;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new NhanVienForm());
            if (checkper("STAFF") == true)
            {
                OpenChildForm(new FrmNhanVienn());
            }
            else
            {
                FrmError warning = new FrmError();
                warning.Show();
                btnNhanVien.Checked = false;
            }

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (checkper("CUSTOMER") == true)
            {
                OpenChildForm(new FrmKhachHang());
            }
            else
            {
                FrmError warning = new FrmError();
                warning.Show();
                btnNhanVien.Checked = false;
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (checkper("BILL") == true)
            {
                OpenChildForm(new FrmHoaDon());
            }
            else
            {
                FrmError warning = new FrmError();
                warning.Show();
                btnNhanVien.Checked = false;
            }
        }


        private void btnDichVu_Click(object sender, EventArgs e)
        {
            if (checkper("SERVICE") == true)
            {
                OpenChildForm(new FrmDichVu());
            }
            else
            {
                FrmError warning = new FrmError();
                warning.Show();
                btnDichVu.Checked = false;
            }
        }

        #region Phân quyền
        string id_per(string id_user)
        {
            string id = "";
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM tbl_per_relationship WHERE id_user_rel ='" + id_user + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        if (dr["suspended"].ToString() == "True")
                        {
                            id = dr["id_per_rel"].ToString();
                        }
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            return id;
        }

        List<string> List_per()
        {
            string idper = id_per(UID);
            List<string> list = new List<string>();
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM tbl_permission_detail WHERE id_per ='" + idper + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        list.Add(dr["code_action"].ToString());
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            return list;
        }
        #endregion



        private void pbThongTinNhanVien_Click_1(object sender, EventArgs e)
        {
            FrmThongTinDangNhap thongTinDangNhap = new FrmThongTinDangNhap();
            thongTinDangNhap.ShowDialog();
        }



        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }



        private void FrmQuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmQuanLi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
