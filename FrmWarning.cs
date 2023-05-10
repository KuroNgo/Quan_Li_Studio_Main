using System;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmWarning : Form
    {
        public FrmWarning()
        {
            InitializeComponent();
        }

        private void btnNoAgree_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgree_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
