using System;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmGioiThieu : Form
    {
        public FrmGioiThieu()
        {
            InitializeComponent();
            
        }

        private void FrmGioiThieu_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
          
          
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label3.Visible = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label4.Visible = true;
        }
    }
}
