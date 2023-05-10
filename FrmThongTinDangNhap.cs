using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmThongTinDangNhap : Form
    {
        public Form currentChildForm;
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnLink.Controls.Add(childForm);
            pnLink.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public FrmThongTinDangNhap()
        {
            InitializeComponent();
        }
        public string TenNhanVien = FrmDangNhap.TenNhanVien;
        public string TenQuyenHan = FrmDangNhap.ChucVuNhanVien;
        public string[] NgaySinh = FrmDangNhap.NgaySinh.Split(' ').ToArray();
        public string SDT = FrmDangNhap.SDT;
        public string Email = FrmDangNhap.Email;
        public string TenTaiKhoan = FrmDangNhap.TenTaiKhoan;
        public string SoCCCD = FrmDangNhap.SoCCCD;
        private void ThongTinDangNhap_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = TenNhanVien;
            lblChucVu.Text = TenQuyenHan;
            lblNgaySinh.Text = NgaySinh[0].ToString();
            lblSDT.Text = SDT;
            lblEmail.Text = Email;
            //lblDiaChi.Text = DiaChi;
            lblTenTaiKhoan.Text = TenTaiKhoan;
            lblCCCD.Text = "Đã ẩn thông tin";
            btnHidden.Checked = true;
            this.KeyPreview = true;
        }

        private void btnSettingLink_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChinhSuaThongTin());
        }

        private void btnHidden_Click_1(object sender, EventArgs e)
        {
            lblCCCD.Text = "Đã ẩn thông tin";
        }

        private void btnUnHidden_Click(object sender, EventArgs e)
        {
            lblCCCD.Text = SoCCCD;
            btnHidden.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            // Ctrl+Esc thực hiện Close
            if (e.KeyCode == Keys.Escape)
            {
                btnExit_Click(null, null);
            }
            if (e.Control)
            {

                //Ctrl+Alt+S thực hiện viện 
            }
        }
    }
}
