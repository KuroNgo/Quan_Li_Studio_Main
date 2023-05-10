namespace QuanLiStudio2
{
    partial class FrmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestore));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgree = new Guna.UI2.WinForms.Guna2Button();
            this.btnNoAgree = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAgree);
            this.panel2.Controls.Add(this.btnNoAgree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 171);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(172, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bạn có muốn thực hiện tác vụ này?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÂU HỎI !";
            // 
            // btnAgree
            // 
            this.btnAgree.BackColor = System.Drawing.Color.Transparent;
            this.btnAgree.BorderRadius = 10;
            this.btnAgree.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAgree.CheckedState.Parent = this.btnAgree;
            this.btnAgree.CustomImages.Parent = this.btnAgree;
            this.btnAgree.FillColor = System.Drawing.Color.Teal;
            this.btnAgree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgree.ForeColor = System.Drawing.Color.White;
            this.btnAgree.HoverState.Parent = this.btnAgree;
            this.btnAgree.Location = new System.Drawing.Point(195, 99);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.ShadowDecoration.BorderRadius = 10;
            this.btnAgree.ShadowDecoration.Enabled = true;
            this.btnAgree.ShadowDecoration.Parent = this.btnAgree;
            this.btnAgree.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnAgree.Size = new System.Drawing.Size(120, 34);
            this.btnAgree.TabIndex = 5;
            this.btnAgree.Text = "Có";
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnNoAgree
            // 
            this.btnNoAgree.BackColor = System.Drawing.Color.Transparent;
            this.btnNoAgree.BorderRadius = 10;
            this.btnNoAgree.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNoAgree.CheckedState.Parent = this.btnNoAgree;
            this.btnNoAgree.CustomImages.Parent = this.btnNoAgree;
            this.btnNoAgree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoAgree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoAgree.ForeColor = System.Drawing.Color.White;
            this.btnNoAgree.HoverState.Parent = this.btnNoAgree;
            this.btnNoAgree.Location = new System.Drawing.Point(323, 99);
            this.btnNoAgree.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoAgree.Name = "btnNoAgree";
            this.btnNoAgree.ShadowDecoration.BorderRadius = 10;
            this.btnNoAgree.ShadowDecoration.Enabled = true;
            this.btnNoAgree.ShadowDecoration.Parent = this.btnNoAgree;
            this.btnNoAgree.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnNoAgree.Size = new System.Drawing.Size(120, 34);
            this.btnNoAgree.TabIndex = 6;
            this.btnNoAgree.Text = "Không";
            this.btnNoAgree.Click += new System.EventHandler(this.btnNoAgree_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 173);
            this.panel1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(260, 23);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(115, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FrmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRestore";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnAgree;
        public Guna.UI2.WinForms.Guna2Button btnNoAgree;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}