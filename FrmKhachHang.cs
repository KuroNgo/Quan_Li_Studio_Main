using BUS_QuanLiStudio;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmKhachHang : Form
    {
        FrmSuccess success=new FrmSuccess();
        BUS_Customer bus_customer = new BUS_Customer();
        FrmWarning warning= new FrmWarning();
        public FrmKhachHang()
        {
            InitializeComponent();
            dtgvDanhSachKhachHang.AutoGenerateColumns = false;
        }
        public void _Delete()
        {
            DataGridViewRow roww = new DataGridViewRow();
            roww = dtgvDanhSachKhachHang.SelectedRows[0];
            int ID = int.Parse(roww.Cells[0].Value.ToString());
            warning.ShowDialog();
            if (warning.btnAgree.Checked == true)
            {
                if (bus_customer.Disable_Customer(ID))
                {
                    success.ShowDialog();
                    dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer();
                }
                else if (bus_customer.Delete_Customer(ID))
                {
                    success.ShowDialog();
                    dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer2();
                }
                else
                {
                    warning.ShowDialog();
                }
            }
        }
        private void Restore()
        {
            int ID = int.Parse(dtgvDanhSachKhachHang.SelectedCells[0].Value.ToString());
            FrmRestore frmRestore = new FrmRestore();
            frmRestore.ShowDialog();
            if (frmRestore.btnAgree.Checked == true)
            {
                if (bus_customer.Enable_Customer(ID))
                {
                    success.ShowDialog();
                    dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer2();
                    lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
                }
                else
                {
                    warning.ShowDialog();
                }
            }
        }
        private void CellDoubleClick()
        {
            try
            {
                FrmThemKhachHang themKhachHang = new FrmThemKhachHang();
                themKhachHang.btnAdd.Enabled = false;
                DataGridViewRow roww = new DataGridViewRow();
                roww = dtgvDanhSachKhachHang.SelectedRows[0];
                themKhachHang.txtID.Text = roww.Cells[0].Value.ToString();
                themKhachHang.txtTenKH.Text = roww.Cells[1].Value.ToString();
                themKhachHang.txtSDT.Text = roww.Cells[2].Value.ToString();
                themKhachHang.txtEmail.Text = roww.Cells[3].Value.ToString();
                string diaChi= roww.Cells[4].Value.ToString();
                string[] listDiaChi=diaChi.Split(',');
                themKhachHang.txtXaPhuong.Text = listDiaChi[0].ToString();
                themKhachHang.txtQuanHuyen.Text = listDiaChi[1].ToString();
                themKhachHang.txtTinhThanhPho.Text = listDiaChi[2].ToString();
                if (int.Parse(roww.Cells[5].Value.ToString()) == 1)
                {
                    themKhachHang.btnSave.Enabled = true;
                    themKhachHang.btnCo.Checked = true;
                    themKhachHang.ShowDialog();
                    dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer();
                    lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
                }
                else
                {
                    themKhachHang.btnSave.Enabled = true;
                    themKhachHang.btnKhong.Checked = true;
                    themKhachHang.ShowDialog();
                    dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer2();
                    lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
                }
            }
            catch (Exception)
            {

            }
        }

        private void LoadAllData()
        {
            dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer();
            lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " khách hàng";
        }

        private void LoadAllDataOfDisable()
        {
            dtgvDanhSachKhachHang.DataSource = bus_customer.getCustomer2();
            lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " khách hàng";
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = false;
            LoadAllData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string vb = txtTimKiem.Text;
            if (cbbLoc.Text == "Tên khách hàng")
            {
                //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
                string SQL = string.Format("{0} like '{1}'", "TenKH", "%" + vb + "%");
                (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
                lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            }
            else if (cbbLoc.Text == "Số điện thoại")
            {
                string SQL = string.Format("{0} like '{1}'", "SoDienThoai", "%" + vb + "%");
                (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
                lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            }
            else if (cbbLoc.Text == "Email")
            {
                string SQL = string.Format("{0} like '{1}'", "Email", "%" + vb + "%");
                (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
                lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            }
            else if (cbbLoc.Text == "Địa chỉ")
            {
                string SQL = string.Format("{0} like '{1}'", "DiaChi", "%" + vb + "%");
                (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
                lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            }
            //else if (cbbLoc.Text == "Huyện")
            //{
            //    string SQL = string.Format("{0} like '{1}'", "Huyen", "%" + vb + "%");
            //    (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
            //    lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            //}
            //else if (cbbLoc.Text == "Tỉnh")
            //{
            //    string SQL = string.Format("{0} like '{1}'", "Tinh", "%" + vb + "%");
            //    (dtgvDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = SQL;
            //    lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachKhachHang.RowCount.ToString() + " Khách hàng";
            //}
            else
            {
                return;
            }
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = false;
            LoadAllData();
            txtTimKiem.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmThemKhachHang frmThemKhachHang = new FrmThemKhachHang();
            frmThemKhachHang.ShowDialog();
            if (btnLoadAllData.Checked == true)
            {
                LoadAllData();
            }
        }

       
        private void dtgvDanhSachKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellDoubleClick();

        }

        private void btnLoadAllDataOfDisable_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = true;
            LoadAllDataOfDisable();
            txtTimKiem.Text = "";
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            CellDoubleClick();
        }
        
        FrmThemKhachHang frmThemKhachHang=new FrmThemKhachHang();
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           _Delete();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmThemKhachHang.ShowDialog();
        }
      
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Restore();
        }
    }
}
