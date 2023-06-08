namespace Final3
{
    partial class frm_home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_maNhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tenNhanVien = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.btn_kho = new System.Windows.Forms.Button();
            this.btn_hoaDon = new System.Windows.Forms.Button();
            this.btn_nhanVien = new System.Windows.Forms.Button();
            this.btn_gioHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lbl_maNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_tenNhanVien);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.btn_dangXuat);
            this.panel1.Controls.Add(this.btn_thongKe);
            this.panel1.Controls.Add(this.btn_kho);
            this.panel1.Controls.Add(this.btn_hoaDon);
            this.panel1.Controls.Add(this.btn_nhanVien);
            this.panel1.Controls.Add(this.btn_gioHang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 1387);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lbl_maNhanVien
            // 
            this.lbl_maNhanVien.AutoSize = true;
            this.lbl_maNhanVien.Location = new System.Drawing.Point(75, 302);
            this.lbl_maNhanVien.Name = "lbl_maNhanVien";
            this.lbl_maNhanVien.Size = new System.Drawing.Size(65, 25);
            this.lbl_maNhanVien.TabIndex = 8;
            this.lbl_maNhanVien.Text = "MNV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "MNV:";
            // 
            // lbl_tenNhanVien
            // 
            this.lbl_tenNhanVien.AutoSize = true;
            this.lbl_tenNhanVien.Location = new System.Drawing.Point(66, 239);
            this.lbl_tenNhanVien.Name = "lbl_tenNhanVien";
            this.lbl_tenNhanVien.Size = new System.Drawing.Size(55, 25);
            this.lbl_tenNhanVien.TabIndex = 7;
            this.lbl_tenNhanVien.Text = "Tên:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(14, 239);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(55, 25);
            this.a.TabIndex = 7;
            this.a.Text = "Tên:";
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_dangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_dangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_dangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_dangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_dangXuat.Location = new System.Drawing.Point(4, 1044);
            this.btn_dangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(288, 125);
            this.btn_dangXuat.TabIndex = 6;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_thongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_thongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_thongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_thongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_thongKe.Location = new System.Drawing.Point(4, 913);
            this.btn_thongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(288, 125);
            this.btn_thongKe.TabIndex = 5;
            this.btn_thongKe.Text = "THỐNG KÊ";
            this.btn_thongKe.UseVisualStyleBackColor = false;
            // 
            // btn_kho
            // 
            this.btn_kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_kho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_kho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_kho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_kho.Location = new System.Drawing.Point(4, 783);
            this.btn_kho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(288, 125);
            this.btn_kho.TabIndex = 4;
            this.btn_kho.Text = "KHO";
            this.btn_kho.UseVisualStyleBackColor = false;
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // btn_hoaDon
            // 
            this.btn_hoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_hoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_hoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_hoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_hoaDon.Location = new System.Drawing.Point(4, 652);
            this.btn_hoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hoaDon.Name = "btn_hoaDon";
            this.btn_hoaDon.Size = new System.Drawing.Size(288, 125);
            this.btn_hoaDon.TabIndex = 3;
            this.btn_hoaDon.Text = "HOÁ ĐƠN";
            this.btn_hoaDon.UseVisualStyleBackColor = false;
            this.btn_hoaDon.Click += new System.EventHandler(this.btn_hoaDon_Click);
            // 
            // btn_nhanVien
            // 
            this.btn_nhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_nhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_nhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_nhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_nhanVien.Location = new System.Drawing.Point(4, 521);
            this.btn_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhanVien.Name = "btn_nhanVien";
            this.btn_nhanVien.Size = new System.Drawing.Size(288, 125);
            this.btn_nhanVien.TabIndex = 2;
            this.btn_nhanVien.Text = "NHÂN VIÊN";
            this.btn_nhanVien.UseVisualStyleBackColor = false;
            this.btn_nhanVien.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_gioHang
            // 
            this.btn_gioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.btn_gioHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_gioHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btn_gioHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gioHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_gioHang.Location = new System.Drawing.Point(4, 390);
            this.btn_gioHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gioHang.Name = "btn_gioHang";
            this.btn_gioHang.Size = new System.Drawing.Size(288, 125);
            this.btn_gioHang.TabIndex = 1;
            this.btn_gioHang.Text = "GIỎ HÀNG";
            this.btn_gioHang.UseVisualStyleBackColor = false;
            this.btn_gioHang.Click += new System.EventHandler(this.btn_gioHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logoFruit;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_body
            // 
            this.pn_body.AutoSize = true;
            this.pn_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.pn_body.Location = new System.Drawing.Point(300, 4);
            this.pn_body.Margin = new System.Windows.Forms.Padding(4);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(2396, 1383);
            this.pn_body.TabIndex = 3;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2696, 1387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.Button btn_kho;
        private System.Windows.Forms.Button btn_hoaDon;
        private System.Windows.Forms.Button btn_nhanVien;
        private System.Windows.Forms.Button btn_gioHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_body;
        private System.Windows.Forms.Label lbl_maNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tenNhanVien;
        private System.Windows.Forms.Label a;
    }
}