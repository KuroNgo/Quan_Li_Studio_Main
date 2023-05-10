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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        private string TabsLeader(int size_of_panel, int size_of_label)
        {
            string tabs = new string('.', size_of_panel - size_of_label);
            return tabs;
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            //int size_of_panel = int.Parse(panel21.Size.Width.ToString());
            //int size_of_lbl = int.Parse(lblTongTien1.Size.Width.ToString());
            //lblTabsLeaders2.Text = TabsLeader(size_of_panel,size_of_lbl);
            //lblTabLeader.Text = TabsLeader(size_of_panel, size_of_lbl);
            //lblTabsLeader.Text = TabsLeader(size_of_panel, size_of_lbl);
            //txtNgayDatCoc.PlaceholderText = DateTime.Now.ToString("dd/MM/yyyy");
            //txtNgayDatLich.PlaceholderText = DateTime.Now.ToString("dd/MM/yyyy");
            //txtNgayToChuc.PlaceholderText = DateTime.Now.ToString("dd/MM/yyyy");
            //txtNgayXuatHoaDon.Text = "Ngày: "+ DateTime.Now.ToString("dd/MM/yyyy")+"    Giờ: "+DateTime.Now.ToString("T");
        }

        private void txtSoTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nếu kiểm tra đầu vào e.KeyChar khác số  => Không nhận gì từ bàn phím (e.Handled = true)
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }

        }
    }
}
