using BUS_QuanLiStudio;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiStudio2
{
    public partial class FrmDichVu : Form
    {
        BUS_Service bus_service = new BUS_Service();
        FrmWarning warning = new FrmWarning();
        FrmSuccess success = new FrmSuccess();
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void DichVuForm_Load(object sender, EventArgs e)
        {
            LoadAllData();
            toolStripMenuItem1.Visible = false;
        }

        public void LoadAllData()
        {
            dtgvDanhSachDV.DataSource = bus_service.getService();
            lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachDV.RowCount.ToString();
        }
        public void LoadAllDataaOfDisable()
        {
            dtgvDanhSachDV.DataSource = bus_service.getServiceOfDisabled();
            lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachDV.RowCount.ToString();
        }
        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = false;
            LoadAllData();
            txtTimKiem.Text = "";
            cbbLoaiDichVu.Text = "";
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string vb = txtTimKiem.Text;
            string SQL = string.Format("{0} like '{1}'", "TenGoiQuay", "%" + vb + "%");
            (dtgvDanhSachDV.DataSource as DataTable).DefaultView.RowFilter = SQL;
            lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachDV.RowCount.ToString();
        }

        private void cbbLoaiDichVu_Click(object sender, EventArgs e)
        {
            cbbLoaiDichVu.DataSource = bus_service.getCategoryService();
            cbbLoaiDichVu.DisplayMember = "LoaiGoiQuay";
            cbbLoaiDichVu.ValueMember = "LoaiGoiQuay";
        }


        private void btnLoadOfDisabled_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = true;
            LoadAllDataaOfDisable();
            txtTimKiem.Text = "";
            cbbLoaiDichVu.Text = "";
        }

        private void cbbLoaiDichVu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string vb = cbbLoaiDichVu.Text;
            string SQL = string.Format("{0} = {1}", "LoaiGoiQuay", vb);
            (dtgvDanhSachDV.DataSource as DataTable).DefaultView.RowFilter = SQL;
            if (btnLoadAllData.Checked == true)
                lblCount.Text = "Danh sách hiện có: " + dtgvDanhSachDV.RowCount.ToString();
        }
        public void _Delete()
        {
            DataGridViewRow roww = new DataGridViewRow();
            roww = dtgvDanhSachDV.SelectedRows[0];
            int ID = int.Parse(roww.Cells[0].Value.ToString());
            warning.ShowDialog();
            if (warning.btnAgree.Checked == true)
            {
                if (bus_service.DisableService(ID))
                {
                    success.ShowDialog();
                    LoadAllData();
                }
                else if (bus_service.DeleteService(ID))
                {
                    success.ShowDialog();
                    LoadAllDataaOfDisable();
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
                FrmThemDichVu themDichVu2 = new FrmThemDichVu();
                DataGridViewRow roww = new DataGridViewRow();
                roww = dtgvDanhSachDV.SelectedRows[0];
                themDichVu2.txtID.Text = roww.Cells[0].Value.ToString();
                themDichVu2.txtTenGoiQuay.Text = roww.Cells[1].Value.ToString();
                themDichVu2.txtLoaiGoiQuay.Text = roww.Cells[2].Value.ToString();
                themDichVu2.txtDonGia.Text = roww.Cells[3].Value.ToString();
                themDichVu2.txtSoNguoiQuay.Text = roww.Cells[4].Value.ToString();
                themDichVu2.txtMoTa.Text = roww.Cells[5].Value.ToString();
                if (int.Parse(roww.Cells[6].Value.ToString()) == 1)
                {
                    themDichVu2.btnAddService.Enabled = false;
                    themDichVu2.btnCo.Checked = true;
                    themDichVu2.btnDelete.Enabled = true;
                    themDichVu2.btnSave.Enabled = true;
                    themDichVu2.ShowDialog();
                    LoadAllData();

                }
                else
                {
                    themDichVu2.btnSave.Enabled = true;
                    themDichVu2.btnKhong.Checked = true;
                    themDichVu2.btnDelete.Enabled = true;
                    themDichVu2.btnAddService.Enabled = false;
                    themDichVu2.ShowDialog();
                    LoadAllDataaOfDisable();
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            catch (NullReferenceException)
            {

            }
            catch (StackOverflowException)
            {

            }
        }
        private void dtgvDanhSachDV_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CellDoubleClick();
        }
        private void ThemButton()
        {
            FrmThemDichVu themDichVu = new FrmThemDichVu();
            themDichVu.btnAddService.Enabled = true;
            themDichVu.ShowDialog();
            if (btnLoadAllData.Checked == true)
            {
                LoadAllData();
            }
        }
        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            ThemButton();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ThemButton();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _Delete();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CellDoubleClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dtgvDanhSachDV.SelectedCells[0].Value.ToString());
            FrmRestore frmRestore = new FrmRestore();
            frmRestore.ShowDialog();
            if (frmRestore.btnAgree.Checked == true)
            {
                if (bus_service.EnableService(ID))
                {
                    success.ShowDialog();
                    LoadAllDataaOfDisable();
                }
                else
                {
                    warning.ShowDialog();
                }
            }
        }
    }
}
