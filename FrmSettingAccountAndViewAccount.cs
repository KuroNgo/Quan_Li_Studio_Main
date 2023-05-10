using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmSettingAccountAndViewAccount : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        public FrmSettingAccountAndViewAccount()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                return;
            }
            else
            {
                string kq = regularExpression.CheckStrength(txtPassword.Text).ToString();
                if (kq == "Blank")
                {
                    lblTestPass.ForeColor = Color.Red;
                    lblTestPass.Text = "Trống";
                }
                else if (kq == "VeryWeak")
                {
                    lblTestPass.ForeColor = Color.Red;
                    lblTestPass.Text = "Rất yếu";
                }
                else if (kq == "Weak")
                {
                    lblTestPass.ForeColor = Color.Red;
                    lblTestPass.Text = "yếu";
                }
                else if (kq == "Medium")
                {
                    lblTestPass.ForeColor = Color.Green;
                    lblTestPass.Text = "Bình thường";
                }
                else if (kq == "Strong")
                {
                    lblTestPass.ForeColor = Color.Green;
                    lblTestPass.Text = "Mạnh";
                }
                else if (kq == "VeryStrong")
                {
                    lblTestPass.ForeColor = Color.Green;
                    lblTestPass.Text = "Rất mạnh";
                }

            }
        }

        private void FrmSettingAccountAndViewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
