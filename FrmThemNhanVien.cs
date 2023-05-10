using BUS_QuanLiStudio;
using Microsoft.VisualBasic;
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
    public partial class FrmThemNhanVien : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        BUS_XaPhuongTinh bUS_XaPhuongTinh=new BUS_XaPhuongTinh();
        public FrmThemNhanVien()
        {
            InitializeComponent();
        }

   

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
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

   

    }
}
