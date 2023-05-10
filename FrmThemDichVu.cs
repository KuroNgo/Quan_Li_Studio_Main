using BUS_QuanLiStudio;
using DTO_QuanLiStudio;
using System;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmThemDichVu : Form
    {
        FrmSuccess success = new FrmSuccess();
        FrmWarning warning = new FrmWarning();
        FrmError error = new FrmError();
        BUS_Service bus_Service = new BUS_Service();
        public FrmThemDichVu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int enablee;
        public void _Add()
        {
            if (btnCo.Checked == true)
            {
                enablee = 1;
            }
            if (btnKhong.Checked == true)
            {
                enablee = 0;
            }
            if (txtTenGoiQuay.Text != "" && txtSoNguoiQuay.Text != ""
               && txtLoaiGoiQuay.Text != "" && txtDonGia.Text != "")
            {
                DTO_Service service = new DTO_Service(0, txtTenGoiQuay.Text.ToString(),
                         int.Parse(txtSoNguoiQuay.Text.ToString()), double.Parse(txtDonGia.Text.ToString()), int.Parse(txtLoaiGoiQuay.Text.ToString())
                        , txtMoTa.Text.ToString(), enablee);
                if (bus_Service.AddService(service))
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
        public void _Delete()
        {
            int ID = int.Parse(txtID.Text.ToString());
            warning.ShowDialog();
            if (warning.btnAgree.Checked == true)
            {
                if (bus_Service.DisableService(ID))
                {
                    success.ShowDialog();
                    this.Close();
                }
                else if (bus_Service.DeleteService(ID))
                {
                    success.ShowDialog();
                    this.Close();
                }
                else
                {
                    warning.ShowDialog();
                    this.Close();
                }
            }
        }
        public void _Save()
        {
            if (btnCo.Checked == true)
            {
                enablee = 1;
            }
            if (btnKhong.Checked == true)
            {
                enablee = 0;
            }
            if (txtTenGoiQuay.Text != "" && txtSoNguoiQuay.Text != ""
                && txtLoaiGoiQuay.Text != "" && txtDonGia.Text != "")
            {
                //Kiểm tra thông tin, nếu có thì cập nhật còn không thì thôi chứ có biết làm gì đâu :(((
                if (bus_Service.CheckExist(int.Parse(txtID.Text.ToString())) == true)
                {
                    DTO_Service dto_Service = new DTO_Service(int.Parse(txtID.Text.ToString()), txtTenGoiQuay.Text.ToString(),
                         int.Parse(txtSoNguoiQuay.Text.ToString()), double.Parse(txtDonGia.Text.ToString()), int.Parse(txtLoaiGoiQuay.Text.ToString())
                        , txtMoTa.Text.ToString(), enablee);
                    if (bus_Service.UpdateService(dto_Service))
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnRemoveLetter_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtLoaiGoiQuay.Text = "";
            txtMoTa.Text = string.Empty;
            txtSoNguoiQuay.Text = string.Empty;
            txtTenGoiQuay.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }
 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Delete();   
        }

     
        private void btnAddService_Click(object sender, EventArgs e)
        {
            _Add();
        }

        private void txtLoaiGoiQuay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác chữ => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 162)
                e.Handled = false;
        }

        private void txtSoNguoiQuay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác chữ => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 162)
                e.Handled = false;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác chữ => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            //Nếu kiểm tra đầu vào e.KeyChar là Backspace / Enter / Comma (dấu .) (e.Handled = false)
            if (e.KeyChar == 13 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 162)
                e.Handled = false;
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDonGia.Text != "" && !txtDonGia.Text.StartsWith("0", StringComparison.InvariantCultureIgnoreCase))
                {
                    double temp = Convert.ToDouble(txtDonGia.Text);
                    txtDonGia.Text = temp.ToString("#,###");
                    lblDonGia.Text = PChucNang.NumberToText(double.Parse(txtDonGia.Text.ToString()));
                    lblDonGia.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void FrmThemDichVu_Load(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "" && !txtDonGia.Text.StartsWith("0", StringComparison.InvariantCultureIgnoreCase))
            {
                double temp = Convert.ToDouble(txtDonGia.Text);
                txtDonGia.Text = temp.ToString("#,###");
                lblDonGia.Text = PChucNang.NumberToText(double.Parse(txtDonGia.Text.ToString()));
                lblDonGia.Visible = true;
            }
            else
            {
                lblDonGia.Visible = false;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "" && !txtDonGia.Text.StartsWith("0",StringComparison.InvariantCultureIgnoreCase))
            {
                lblDonGia.Text = PChucNang.NumberToText(double.Parse(txtDonGia.Text.ToString()));
                lblDonGia.Visible = true;
            }
            else
            {
                lblDonGia.Visible= false;
            }
        }
    }
}
