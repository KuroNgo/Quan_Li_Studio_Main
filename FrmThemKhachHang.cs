using BUS_QuanLiStudio;
using DTO_QuanLiStudio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmThemKhachHang : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        BUS_XaPhuongTinh bUS_XaPhuongTinh = new BUS_XaPhuongTinh();
        BUS_Customer BUS_Customer = new BUS_Customer();
        FrmSuccess success = new FrmSuccess();
        FrmWarning warning = new FrmWarning();
        FrmError error = new FrmError();
        byte[] photo_aray = null;
        int enablee;
        public FrmThemKhachHang()
        {
            InitializeComponent();
        }

        public void _Delete()
        {
            int ID = int.Parse(txtID.Text.ToString());
            warning.ShowDialog();
            if (warning.btnAgree.Checked == true)
            {
                if (BUS_Customer.Disable_Customer(ID))
                {
                    success.ShowDialog();
                    this.Close();
                }
                else if (BUS_Customer.Delete_Customer(ID))
                {
                    success.ShowDialog();
                    this.Close();
                }
                else
                {
                    error.ShowDialog();
                    this.Close();
                }
            }
        }
        public void _Add()
        {
            if (txtTenKH.Text != "" && txtSDT.Text != ""
          && txtTinhThanhPho.Text != "" && txtQuanHuyen.Text != "" && txtXaPhuong.Text != "")
            {

                DTO_Customer customer = new DTO_Customer(0, txtTenKH.Text.ToString(),
                       txtSDT.Text.ToString(), txtEmail.Text.ToString(), 1, txtXaPhuong.Text.ToString(),
                       txtQuanHuyen.Text.ToString(), txtTinhThanhPho.Text.ToString(), photo_aray);
                if (BUS_Customer.Add_Customer(customer))
                {
                    success.ShowDialog();
                    this.Close();
                }
                else
                {
                    error.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void _Update()
        {
            if (btnCo.Checked == true)
            {
                enablee = 1;
            }
            if (btnKhong.Checked == true)
            {
                enablee = 0;
            }
            if (txtTenKH.Text != "" && txtSDT.Text != ""
            && txtTinhThanhPho.Text != "" && txtQuanHuyen.Text != "" && txtXaPhuong.Text != "")
            {

                DTO_Customer customer = new DTO_Customer(int.Parse(txtID.Text.ToString()), txtTenKH.Text.ToString(),
                       txtSDT.Text.ToString(), txtEmail.Text.ToString(), enablee, txtXaPhuong.Text.ToString(),
                       txtQuanHuyen.Text.ToString(), txtTinhThanhPho.Text.ToString(), photo_aray);
                //Kiểm tra thông tin, nếu có thì cập nhật còn không thì thôi chứ có biết làm gì đâu :(((
                if (BUS_Customer.CheckExist(int.Parse(txtID.Text.ToString())) == true)
                {
                    if (BUS_Customer.Update_Customer(customer))
                    {
                        success.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        error.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Delete();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblTestText_Email.Visible = false;
                return;
            }
            else
            {
                if (regularExpression.IsEmail(txtEmail.Text) == false)
                {
                    lblTestText_Email.Visible = true;
                    string vb = txtEmail.Text;
                    txtEmail.Text = vb + "@gmail.com";
                }
            }
        }

        private void btnRemoveLetter_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSDT.Text = string.Empty;
            txtTenKH.Text = string.Empty;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                lblTestText_SDT.Visible = false;
                return;
            }
            else
            {
                if (regularExpression.IsPhone(txtSDT.Text) == true)
                {
                    lblTestText_SDT.Visible = true;
                    lblTestText_SDT.ForeColor = Color.Green;
                    lblTestText_SDT.Text = "Số điện thoại hợp lệ";
                }
                else
                {
                    lblTestText_SDT.Visible = true;
                    lblTestText_SDT.ForeColor = Color.Red;
                    lblTestText_SDT.Text = "Số điện thoại không hợp lệ";
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblTestText_Email.Visible = false;
                return;
            }
            else
            {
                if (regularExpression.IsEmail(txtEmail.Text) == true)
                {
                    lblTestText_Email.Visible = true;
                    lblTestText_Email.ForeColor = Color.Green;
                    lblTestText_Email.Text = "Email hợp lệ";
                }
                else
                {
                    lblTestText_Email.Visible = true;
                    lblTestText_Email.ForeColor = Color.Red;
                    lblTestText_Email.Text = "Email không hợp lệ";
                }
            }
        }

        private void cbbTinh_Click(object sender, EventArgs e)
        {
            cbbTinh.DataSource = bUS_XaPhuongTinh.getTinh();
            cbbTinh.DisplayMember = "TenTinhThanhPho";
            cbbTinh.ValueMember = "ID";
        }


        private void FrmThemKhachHang_Load(object sender, EventArgs e)
        {
            cbbTinh.DataSource = bUS_XaPhuongTinh.getTinh();
            cbbTinh.DisplayMember = "TenTinhThanhPho";
            cbbTinh.ValueMember = "ID";
            string idTinh = cbbTinh.SelectedValue.ToString();
            cbbHuyen.DataSource = bUS_XaPhuongTinh.getHuyen(idTinh);
            cbbHuyen.DisplayMember = "TenQuanHuyen";
            cbbHuyen.ValueMember = "ID";
            string idHuyen = cbbHuyen.SelectedValue.ToString();
            cbbXa.DataSource = bUS_XaPhuongTinh.getXa(idHuyen);
            cbbXa.DisplayMember = "tenXaPhuong";
            cbbXa.ValueMember = "ID";
            txtTinhThanhPho.Text = cbbTinh.Text;
            txtQuanHuyen.Text = cbbHuyen.Text;
            txtXaPhuong.Text = cbbXa.Text;

        }

        private void cbbTinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (cbbTinh.Text != "")
            {
                string idTinh = cbbTinh.SelectedValue.ToString();
                cbbHuyen.DataSource = bUS_XaPhuongTinh.getHuyen(idTinh);
                cbbHuyen.DisplayMember = "TenQuanHuyen";
                cbbHuyen.ValueMember = "ID";
                txtTinhThanhPho.Text = cbbTinh.Text;
                txtQuanHuyen.Text = cbbHuyen.Text;
                string idHuyen = cbbHuyen.SelectedValue.ToString();
                cbbXa.DataSource = bUS_XaPhuongTinh.getXa(idHuyen);
                cbbXa.DisplayMember = "tenXaPhuong";
                cbbXa.ValueMember = "ID";
                txtXaPhuong.Text = cbbXa.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tỉnh/thành phố", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cbbHuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            if (cbbHuyen.Text != "")
            {
                string idHuyen = cbbHuyen.SelectedValue.ToString();
                cbbXa.DataSource = bUS_XaPhuongTinh.getXa(idHuyen);
                cbbXa.DisplayMember = "tenXaPhuong";
                cbbXa.ValueMember = "ID";
                txtQuanHuyen.Text = cbbHuyen.Text;
                txtXaPhuong.Text = cbbXa.Text;
            }
            else
            {
                MessageBox.Show("Trường quận huyện hoặc tỉnh thành phố còn trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cbbXa_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            txtXaPhuong.Text = cbbXa.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Add();
        }

        private void txtTinhThanhPho_Leave(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác số => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 162)
                e.Handled = false;
        }

        private void txtTinhF2_Click(object sender, EventArgs e)
        {
            //txtTinhF2.Visible=false;
            //txtHuyenF2.Visible=false;
            //txtXaF2.Visible=false;
        }

        private void txtHuyenF2_Click(object sender, EventArgs e)
        {
         
        }

        private void txtXaF2_Click(object sender, EventArgs e)
        {
            //txtTinhF2.Visible=false;
            //txtHuyenF2.Visible=false;
            //txtXaF2.Visible=false;
        }

       
    }
}
