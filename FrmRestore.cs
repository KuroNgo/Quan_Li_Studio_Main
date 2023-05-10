using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmRestore : Form
    {
        public FrmRestore()
        {
            InitializeComponent();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoAgree_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
