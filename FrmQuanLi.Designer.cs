
namespace QuanLiStudio2
{
    partial class FrmQuanLi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLi));
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTongQuan = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlink = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.pbThongTinNhanVien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.AutomaticDelay = 1500;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(1422, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(67, 50);
            this.btnMinimize.TabIndex = 7;
            this.guna2HtmlToolTip1.SetToolTip(this.btnMinimize, "Ẩn");
            this.btnMinimize.UseTransparentBackground = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(12, 12);
            this.btnExit.Location = new System.Drawing.Point(1489, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(67, 50);
            this.btnExit.TabIndex = 9;
            this.guna2HtmlToolTip1.SetToolTip(this.btnExit, "Thoát");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Controls.Add(this.btnDichVu);
            this.panel2.Controls.Add(this.btnTongQuan);
            this.panel2.Controls.Add(this.btnExit2);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnKhachHang);
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 834);
            this.panel2.TabIndex = 11;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.Transparent;
            this.btnExit2.BorderRadius = 15;
            this.btnExit2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit2.CheckedState.Parent = this.btnExit2;
            this.btnExit2.CustomImages.Parent = this.btnExit2;
            this.btnExit2.FillColor = System.Drawing.Color.White;
            this.btnExit2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.ForeColor = System.Drawing.Color.Black;
            this.btnExit2.HoverState.Parent = this.btnExit2;
            this.btnExit2.Image = ((System.Drawing.Image)(resources.GetObject("btnExit2.Image")));
            this.btnExit2.ImageOffset = new System.Drawing.Point(20, -15);
            this.btnExit2.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit2.Location = new System.Drawing.Point(36, 825);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.ShadowDecoration.BorderRadius = 15;
            this.btnExit2.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnExit2.ShadowDecoration.Enabled = true;
            this.btnExit2.ShadowDecoration.Parent = this.btnExit2;
            this.btnExit2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnExit2.Size = new System.Drawing.Size(135, 95);
            this.btnExit2.TabIndex = 14;
            this.btnExit2.Text = "Đăng xuất";
            this.btnExit2.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.Transparent;
            this.btnDichVu.BorderRadius = 15;
            this.btnDichVu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDichVu.CheckedState.Parent = this.btnDichVu;
            this.btnDichVu.CustomImages.Parent = this.btnDichVu;
            this.btnDichVu.FillColor = System.Drawing.Color.White;
            this.btnDichVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.HoverState.Parent = this.btnDichVu;
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.ImageOffset = new System.Drawing.Point(14, -15);
            this.btnDichVu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDichVu.Location = new System.Drawing.Point(36, 518);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ShadowDecoration.BorderRadius = 15;
            this.btnDichVu.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnDichVu.ShadowDecoration.Enabled = true;
            this.btnDichVu.ShadowDecoration.Parent = this.btnDichVu;
            this.btnDichVu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnDichVu.Size = new System.Drawing.Size(135, 98);
            this.btnDichVu.TabIndex = 14;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 15;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.Parent = this.btnNhanVien;
            this.btnNhanVien.CustomImages.Parent = this.btnNhanVien;
            this.btnNhanVien.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.HoverState.Parent = this.btnNhanVien;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageOffset = new System.Drawing.Point(20, -15);
            this.btnNhanVien.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNhanVien.Location = new System.Drawing.Point(36, 394);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ShadowDecoration.BorderRadius = 15;
            this.btnNhanVien.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnNhanVien.ShadowDecoration.Enabled = true;
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnNhanVien.Size = new System.Drawing.Size(135, 98);
            this.btnNhanVien.TabIndex = 14;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderRadius = 15;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.Parent = this.btnKhachHang;
            this.btnKhachHang.CustomImages.Parent = this.btnKhachHang;
            this.btnKhachHang.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.HoverState.Parent = this.btnKhachHang;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageOffset = new System.Drawing.Point(23, -15);
            this.btnKhachHang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKhachHang.Location = new System.Drawing.Point(36, 271);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ShadowDecoration.BorderRadius = 15;
            this.btnKhachHang.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnKhachHang.ShadowDecoration.Enabled = true;
            this.btnKhachHang.ShadowDecoration.Parent = this.btnKhachHang;
            this.btnKhachHang.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnKhachHang.Size = new System.Drawing.Size(135, 98);
            this.btnKhachHang.TabIndex = 14;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.BorderRadius = 15;
            this.btnHoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHoaDon.CheckedState.Parent = this.btnHoaDon;
            this.btnHoaDon.CustomImages.Parent = this.btnHoaDon;
            this.btnHoaDon.FillColor = System.Drawing.Color.White;
            this.btnHoaDon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.HoverState.Parent = this.btnHoaDon;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageOffset = new System.Drawing.Point(16, -15);
            this.btnHoaDon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHoaDon.Location = new System.Drawing.Point(36, 151);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ShadowDecoration.BorderRadius = 15;
            this.btnHoaDon.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnHoaDon.ShadowDecoration.Enabled = true;
            this.btnHoaDon.ShadowDecoration.Parent = this.btnHoaDon;
            this.btnHoaDon.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnHoaDon.Size = new System.Drawing.Size(135, 98);
            this.btnHoaDon.TabIndex = 14;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.Transparent;
            this.btnTongQuan.BorderRadius = 15;
            this.btnTongQuan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTongQuan.CheckedState.Parent = this.btnTongQuan;
            this.btnTongQuan.CustomImages.Parent = this.btnTongQuan;
            this.btnTongQuan.FillColor = System.Drawing.Color.White;
            this.btnTongQuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.Black;
            this.btnTongQuan.HoverState.Parent = this.btnTongQuan;
            this.btnTongQuan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongQuan.Image")));
            this.btnTongQuan.ImageOffset = new System.Drawing.Point(20, -15);
            this.btnTongQuan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTongQuan.Location = new System.Drawing.Point(36, 636);
            this.btnTongQuan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.ShadowDecoration.BorderRadius = 15;
            this.btnTongQuan.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnTongQuan.ShadowDecoration.Enabled = true;
            this.btnTongQuan.ShadowDecoration.Parent = this.btnTongQuan;
            this.btnTongQuan.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btnTongQuan.Size = new System.Drawing.Size(135, 98);
            this.btnTongQuan.TabIndex = 14;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 90);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 744);
            this.panel6.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 90);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "PRODUCTION";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "TAM";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 14);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(67, 62);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(269, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 834);
            this.panel4.TabIndex = 12;
            // 
            // pnlink
            // 
            this.pnlink.AutoScroll = true;
            this.pnlink.AutoScrollMargin = new System.Drawing.Size(5, 10);
            this.pnlink.AutoScrollMinSize = new System.Drawing.Size(5, 10);
            this.pnlink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlink.Location = new System.Drawing.Point(282, 50);
            this.pnlink.Margin = new System.Windows.Forms.Padding(4);
            this.pnlink.Name = "pnlink";
            this.pnlink.Size = new System.Drawing.Size(1274, 834);
            this.pnlink.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblChucVu);
            this.panel1.Controls.Add(this.pbThongTinNhanVien);
            this.panel1.Controls.Add(this.lblTenNhanVien);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.Silver;
            this.lblChucVu.Location = new System.Drawing.Point(72, 27);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(28, 15);
            this.lblChucVu.TabIndex = 26;
            this.lblChucVu.Text = "123";
            // 
            // pbThongTinNhanVien
            // 
            this.pbThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.pbThongTinNhanVien.FillColor = System.Drawing.Color.Transparent;
            this.pbThongTinNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("pbThongTinNhanVien.Image")));
            this.pbThongTinNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbThongTinNhanVien.Location = new System.Drawing.Point(24, 5);
            this.pbThongTinNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbThongTinNhanVien.Name = "pbThongTinNhanVien";
            this.pbThongTinNhanVien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbThongTinNhanVien.ShadowDecoration.Parent = this.pbThongTinNhanVien;
            this.pbThongTinNhanVien.Size = new System.Drawing.Size(40, 39);
            this.pbThongTinNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThongTinNhanVien.TabIndex = 28;
            this.pbThongTinNhanVien.TabStop = false;
            this.pbThongTinNhanVien.Click += new System.EventHandler(this.pbThongTinNhanVien_Click_1);
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.LightGray;
            this.lblTenNhanVien.Location = new System.Drawing.Point(71, 5);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(40, 23);
            this.lblTenNhanVien.TabIndex = 27;
            this.lblTenNhanVien.Text = "123";
            // 
            // FrmQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.pnlink);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmQuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Studio";
            this.Load += new System.EventHandler(this.FrmQuanLi_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmQuanLi_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlink;
        private Guna.UI2.WinForms.Guna2Button btnTongQuan;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDichVu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbThongTinNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnExit2;
        private System.Windows.Forms.Label lblChucVu;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}

