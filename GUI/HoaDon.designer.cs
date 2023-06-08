
namespace GUI
{
    partial class frm_HoaDon
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
            this.tcr_nhanVien = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datetime_ngaylap_hoadon = new System.Windows.Forms.DateTimePicker();
            this.btn_capnhat_hoadon = new System.Windows.Forms.Button();
            this.btn_xoa_hoadon = new System.Windows.Forms.Button();
            this.btn_timKiemHoaDon = new System.Windows.Forms.Button();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.txt_timKiemHoaDon = new System.Windows.Forms.TextBox();
            this.txt_chietkhau_hoadon = new System.Windows.Forms.TextBox();
            this.txt_thanhtien_hoadon = new System.Windows.Forms.TextBox();
            this.txt_makhachhang_hoadon = new System.Windows.Forms.TextBox();
            this.txt_manhanvien_hoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_kh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_tonggiacthd = new System.Windows.Forms.TextBox();
            this.btn_timkiem_cthd = new System.Windows.Forms.Button();
            this.btn_xoa_cthd = new System.Windows.Forms.Button();
            this.dgv_CThoadon = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_slcthd = new System.Windows.Forms.TextBox();
            this.txt_giamgiacthd = new System.Windows.Forms.TextBox();
            this.txt_giacthd = new System.Windows.Forms.TextBox();
            this.txt_matraicaycthd = new System.Windows.Forms.TextBox();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVien_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maHoaDon = new System.Windows.Forms.TextBox();
            this.id_cthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traiCay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcr_nhanVien.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CThoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // tcr_nhanVien
            // 
            this.tcr_nhanVien.Controls.Add(this.tabPage1);
            this.tcr_nhanVien.Controls.Add(this.tabPage2);
            this.tcr_nhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcr_nhanVien.Location = new System.Drawing.Point(0, 0);
            this.tcr_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tcr_nhanVien.Name = "tcr_nhanVien";
            this.tcr_nhanVien.SelectedIndex = 0;
            this.tcr_nhanVien.Size = new System.Drawing.Size(2392, 1383);
            this.tcr_nhanVien.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.datetime_ngaylap_hoadon);
            this.tabPage1.Controls.Add(this.btn_capnhat_hoadon);
            this.tabPage1.Controls.Add(this.btn_xoa_hoadon);
            this.tabPage1.Controls.Add(this.btn_timKiemHoaDon);
            this.tabPage1.Controls.Add(this.dgv_hoadon);
            this.tabPage1.Controls.Add(this.txt_timKiemHoaDon);
            this.tabPage1.Controls.Add(this.txt_chietkhau_hoadon);
            this.tabPage1.Controls.Add(this.txt_thanhtien_hoadon);
            this.tabPage1.Controls.Add(this.txt_makhachhang_hoadon);
            this.tabPage1.Controls.Add(this.txt_maHoaDon);
            this.tabPage1.Controls.Add(this.txt_manhanvien_hoadon);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lb_kh);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(2376, 1336);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Hóa Đơn";
            // 
            // datetime_ngaylap_hoadon
            // 
            this.datetime_ngaylap_hoadon.Location = new System.Drawing.Point(282, 263);
            this.datetime_ngaylap_hoadon.Margin = new System.Windows.Forms.Padding(6);
            this.datetime_ngaylap_hoadon.Name = "datetime_ngaylap_hoadon";
            this.datetime_ngaylap_hoadon.Size = new System.Drawing.Size(396, 32);
            this.datetime_ngaylap_hoadon.TabIndex = 43;
            // 
            // btn_capnhat_hoadon
            // 
            this.btn_capnhat_hoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_capnhat_hoadon.Location = new System.Drawing.Point(990, 360);
            this.btn_capnhat_hoadon.Margin = new System.Windows.Forms.Padding(6);
            this.btn_capnhat_hoadon.Name = "btn_capnhat_hoadon";
            this.btn_capnhat_hoadon.Size = new System.Drawing.Size(150, 62);
            this.btn_capnhat_hoadon.TabIndex = 42;
            this.btn_capnhat_hoadon.Text = "Cập nhật";
            this.btn_capnhat_hoadon.UseVisualStyleBackColor = true;
            this.btn_capnhat_hoadon.Click += new System.EventHandler(this.btn_capnhat_hoadon_Click);
            // 
            // btn_xoa_hoadon
            // 
            this.btn_xoa_hoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_xoa_hoadon.Location = new System.Drawing.Point(814, 360);
            this.btn_xoa_hoadon.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xoa_hoadon.Name = "btn_xoa_hoadon";
            this.btn_xoa_hoadon.Size = new System.Drawing.Size(150, 62);
            this.btn_xoa_hoadon.TabIndex = 41;
            this.btn_xoa_hoadon.Text = "Xóa ";
            this.btn_xoa_hoadon.UseVisualStyleBackColor = true;
            this.btn_xoa_hoadon.Click += new System.EventHandler(this.btn_xoa_hoadon_Click);
            // 
            // btn_timKiemHoaDon
            // 
            this.btn_timKiemHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_timKiemHoaDon.Location = new System.Drawing.Point(1180, 55);
            this.btn_timKiemHoaDon.Margin = new System.Windows.Forms.Padding(6);
            this.btn_timKiemHoaDon.Name = "btn_timKiemHoaDon";
            this.btn_timKiemHoaDon.Size = new System.Drawing.Size(150, 65);
            this.btn_timKiemHoaDon.TabIndex = 39;
            this.btn_timKiemHoaDon.Text = "Tìm kiếm";
            this.btn_timKiemHoaDon.UseVisualStyleBackColor = true;
            this.btn_timKiemHoaDon.Click += new System.EventHandler(this.btn_timKiemHoaDon_Click);
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.khachHang_id,
            this.nhanVien_id,
            this.ngayLap,
            this.thanhTien,
            this.chietKhau,
            this.dataGridViewTextBoxColumn7});
            this.dgv_hoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_hoadon.Location = new System.Drawing.Point(6, 490);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 82;
            this.dgv_hoadon.RowTemplate.Height = 33;
            this.dgv_hoadon.Size = new System.Drawing.Size(2364, 840);
            this.dgv_hoadon.TabIndex = 25;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // txt_timKiemHoaDon
            // 
            this.txt_timKiemHoaDon.Location = new System.Drawing.Point(786, 70);
            this.txt_timKiemHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timKiemHoaDon.Name = "txt_timKiemHoaDon";
            this.txt_timKiemHoaDon.Size = new System.Drawing.Size(380, 32);
            this.txt_timKiemHoaDon.TabIndex = 38;
            this.txt_timKiemHoaDon.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txt_chietkhau_hoadon
            // 
            this.txt_chietkhau_hoadon.Location = new System.Drawing.Point(282, 394);
            this.txt_chietkhau_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chietkhau_hoadon.Multiline = true;
            this.txt_chietkhau_hoadon.Name = "txt_chietkhau_hoadon";
            this.txt_chietkhau_hoadon.ReadOnly = true;
            this.txt_chietkhau_hoadon.Size = new System.Drawing.Size(396, 34);
            this.txt_chietkhau_hoadon.TabIndex = 36;
            // 
            // txt_thanhtien_hoadon
            // 
            this.txt_thanhtien_hoadon.Location = new System.Drawing.Point(282, 334);
            this.txt_thanhtien_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thanhtien_hoadon.Multiline = true;
            this.txt_thanhtien_hoadon.Name = "txt_thanhtien_hoadon";
            this.txt_thanhtien_hoadon.Size = new System.Drawing.Size(396, 32);
            this.txt_thanhtien_hoadon.TabIndex = 35;
            // 
            // txt_makhachhang_hoadon
            // 
            this.txt_makhachhang_hoadon.Location = new System.Drawing.Point(282, 195);
            this.txt_makhachhang_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_makhachhang_hoadon.Multiline = true;
            this.txt_makhachhang_hoadon.Name = "txt_makhachhang_hoadon";
            this.txt_makhachhang_hoadon.Size = new System.Drawing.Size(396, 32);
            this.txt_makhachhang_hoadon.TabIndex = 33;
            // 
            // txt_manhanvien_hoadon
            // 
            this.txt_manhanvien_hoadon.Location = new System.Drawing.Point(282, 140);
            this.txt_manhanvien_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_manhanvien_hoadon.Multiline = true;
            this.txt_manhanvien_hoadon.Name = "txt_manhanvien_hoadon";
            this.txt_manhanvien_hoadon.Size = new System.Drawing.Size(396, 33);
            this.txt_manhanvien_hoadon.TabIndex = 32;
            this.txt_manhanvien_hoadon.TextChanged += new System.EventHandler(this.txt_manhanvien_hoadon_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(73, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Chiết Khấu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(74, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Thành Tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(74, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ngày Lập:";
            // 
            // lb_kh
            // 
            this.lb_kh.AutoSize = true;
            this.lb_kh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.lb_kh.Location = new System.Drawing.Point(74, 201);
            this.lb_kh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kh.Name = "lb_kh";
            this.lb_kh.Size = new System.Drawing.Size(188, 26);
            this.lb_kh.TabIndex = 27;
            this.lb_kh.Text = "Mã Khách Hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label12.Location = new System.Drawing.Point(74, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mã nhân viên:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.txt_tonggiacthd);
            this.tabPage2.Controls.Add(this.btn_timkiem_cthd);
            this.tabPage2.Controls.Add(this.btn_xoa_cthd);
            this.tabPage2.Controls.Add(this.dgv_CThoadon);
            this.tabPage2.Controls.Add(this.txt_timkiem);
            this.tabPage2.Controls.Add(this.txt_slcthd);
            this.tabPage2.Controls.Add(this.txt_giamgiacthd);
            this.tabPage2.Controls.Add(this.txt_giacthd);
            this.tabPage2.Controls.Add(this.txt_matraicaycthd);
            this.tabPage2.Controls.Add(this.txt_macthd);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(2376, 1336);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "CT_Hóa Đơn";
            // 
            // txt_tonggiacthd
            // 
            this.txt_tonggiacthd.Location = new System.Drawing.Point(818, 137);
            this.txt_tonggiacthd.Margin = new System.Windows.Forms.Padding(6);
            this.txt_tonggiacthd.Name = "txt_tonggiacthd";
            this.txt_tonggiacthd.Size = new System.Drawing.Size(326, 32);
            this.txt_tonggiacthd.TabIndex = 61;
            // 
            // btn_timkiem_cthd
            // 
            this.btn_timkiem_cthd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_timkiem_cthd.Location = new System.Drawing.Point(468, 6);
            this.btn_timkiem_cthd.Margin = new System.Windows.Forms.Padding(6);
            this.btn_timkiem_cthd.Name = "btn_timkiem_cthd";
            this.btn_timkiem_cthd.Size = new System.Drawing.Size(150, 65);
            this.btn_timkiem_cthd.TabIndex = 60;
            this.btn_timkiem_cthd.Text = "Tìm kiếm";
            this.btn_timkiem_cthd.UseVisualStyleBackColor = true;
            this.btn_timkiem_cthd.Click += new System.EventHandler(this.btn_timkiem_cthd_Click);
            // 
            // btn_xoa_cthd
            // 
            this.btn_xoa_cthd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btn_xoa_cthd.Location = new System.Drawing.Point(818, 336);
            this.btn_xoa_cthd.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xoa_cthd.Name = "btn_xoa_cthd";
            this.btn_xoa_cthd.Size = new System.Drawing.Size(150, 62);
            this.btn_xoa_cthd.TabIndex = 58;
            this.btn_xoa_cthd.Text = "Xóa ";
            this.btn_xoa_cthd.UseVisualStyleBackColor = true;
            this.btn_xoa_cthd.Click += new System.EventHandler(this.btn_xoa_cthd_Click);
            // 
            // dgv_CThoadon
            // 
            this.dgv_CThoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CThoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dgv_CThoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CThoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cthd,
            this.traiCay_id,
            this.gia,
            this.soLuong,
            this.giamGia,
            this.tongGia});
            this.dgv_CThoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_CThoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dgv_CThoadon.Location = new System.Drawing.Point(6, 478);
            this.dgv_CThoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CThoadon.Name = "dgv_CThoadon";
            this.dgv_CThoadon.RowHeadersWidth = 82;
            this.dgv_CThoadon.RowTemplate.Height = 33;
            this.dgv_CThoadon.Size = new System.Drawing.Size(2364, 852);
            this.dgv_CThoadon.TabIndex = 43;
            this.dgv_CThoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CThoadon_CellClick);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(74, 21);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(380, 32);
            this.txt_timkiem.TabIndex = 56;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // txt_slcthd
            // 
            this.txt_slcthd.Location = new System.Drawing.Point(818, 83);
            this.txt_slcthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_slcthd.Name = "txt_slcthd";
            this.txt_slcthd.Size = new System.Drawing.Size(326, 32);
            this.txt_slcthd.TabIndex = 54;
            // 
            // txt_giamgiacthd
            // 
            this.txt_giamgiacthd.Location = new System.Drawing.Point(276, 275);
            this.txt_giamgiacthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giamgiacthd.Name = "txt_giamgiacthd";
            this.txt_giamgiacthd.ReadOnly = true;
            this.txt_giamgiacthd.Size = new System.Drawing.Size(326, 32);
            this.txt_giamgiacthd.TabIndex = 53;
            // 
            // txt_giacthd
            // 
            this.txt_giacthd.Location = new System.Drawing.Point(276, 210);
            this.txt_giacthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giacthd.Name = "txt_giacthd";
            this.txt_giacthd.Size = new System.Drawing.Size(326, 32);
            this.txt_giacthd.TabIndex = 52;
            // 
            // txt_matraicaycthd
            // 
            this.txt_matraicaycthd.Location = new System.Drawing.Point(276, 137);
            this.txt_matraicaycthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matraicaycthd.Name = "txt_matraicaycthd";
            this.txt_matraicaycthd.Size = new System.Drawing.Size(326, 32);
            this.txt_matraicaycthd.TabIndex = 51;
            // 
            // txt_macthd
            // 
            this.txt_macthd.Enabled = false;
            this.txt_macthd.Location = new System.Drawing.Point(276, 81);
            this.txt_macthd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.ReadOnly = true;
            this.txt_macthd.Size = new System.Drawing.Size(326, 32);
            this.txt_macthd.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(682, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 26);
            this.label13.TabIndex = 49;
            this.label13.Text = "Tổng Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(678, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(68, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Giảm Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(68, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(68, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mã Trái Cây:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(68, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 26);
            this.label10.TabIndex = 44;
            this.label10.Text = "Mã Hóa Đơn:";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã Hóa Đơn";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            // 
            // khachHang_id
            // 
            this.khachHang_id.DataPropertyName = "khachHang_id";
            this.khachHang_id.HeaderText = "Mã Khách Hàng";
            this.khachHang_id.MinimumWidth = 10;
            this.khachHang_id.Name = "khachHang_id";
            // 
            // nhanVien_id
            // 
            this.nhanVien_id.DataPropertyName = "nhanVien_id";
            this.nhanVien_id.HeaderText = "Mã Nhân Viên";
            this.nhanVien_id.MinimumWidth = 10;
            this.nhanVien_id.Name = "nhanVien_id";
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày Lập";
            this.ngayLap.MinimumWidth = 10;
            this.ngayLap.Name = "ngayLap";
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.MinimumWidth = 10;
            this.thanhTien.Name = "thanhTien";
            // 
            // chietKhau
            // 
            this.chietKhau.DataPropertyName = "chietKhau";
            this.chietKhau.HeaderText = "Chiết Khấu";
            this.chietKhau.MinimumWidth = 10;
            this.chietKhau.Name = "chietKhau";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "trangThai";
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(74, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // txt_maHoaDon
            // 
            this.txt_maHoaDon.Location = new System.Drawing.Point(282, 71);
            this.txt_maHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maHoaDon.Multiline = true;
            this.txt_maHoaDon.Name = "txt_maHoaDon";
            this.txt_maHoaDon.ReadOnly = true;
            this.txt_maHoaDon.Size = new System.Drawing.Size(396, 33);
            this.txt_maHoaDon.TabIndex = 32;
            this.txt_maHoaDon.TextChanged += new System.EventHandler(this.txt_manhanvien_hoadon_TextChanged);
            // 
            // id_cthd
            // 
            this.id_cthd.DataPropertyName = "id";
            this.id_cthd.HeaderText = "Mã Hóa Đơn";
            this.id_cthd.MinimumWidth = 10;
            this.id_cthd.Name = "id_cthd";
            // 
            // traiCay_id
            // 
            this.traiCay_id.DataPropertyName = "traiCay_id";
            this.traiCay_id.HeaderText = "Mã Trái Cây";
            this.traiCay_id.MinimumWidth = 10;
            this.traiCay_id.Name = "traiCay_id";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 10;
            this.gia.Name = "gia";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 10;
            this.soLuong.Name = "soLuong";
            // 
            // giamGia
            // 
            this.giamGia.DataPropertyName = "giamGia";
            this.giamGia.HeaderText = "Giảm Giá";
            this.giamGia.MinimumWidth = 10;
            this.giamGia.Name = "giamGia";
            // 
            // tongGia
            // 
            this.tongGia.DataPropertyName = "tongGia";
            this.tongGia.HeaderText = "Tổng Giá";
            this.tongGia.MinimumWidth = 10;
            this.tongGia.Name = "tongGia";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2392, 1383);
            this.Controls.Add(this.tcr_nhanVien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.tcr_nhanVien.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CThoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcr_nhanVien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.TextBox txt_timKiemHoaDon;
        private System.Windows.Forms.TextBox txt_chietkhau_hoadon;
        private System.Windows.Forms.TextBox txt_thanhtien_hoadon;
        private System.Windows.Forms.TextBox txt_makhachhang_hoadon;
        private System.Windows.Forms.TextBox txt_manhanvien_hoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_kh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_CThoadon;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_slcthd;
        private System.Windows.Forms.TextBox txt_giamgiacthd;
        private System.Windows.Forms.TextBox txt_giacthd;
        private System.Windows.Forms.TextBox txt_matraicaycthd;
        private System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_capnhat_hoadon;
        private System.Windows.Forms.Button btn_xoa_hoadon;
        private System.Windows.Forms.Button btn_timKiemHoaDon;
        private System.Windows.Forms.Button btn_timkiem_cthd;
        private System.Windows.Forms.Button btn_xoa_cthd;
        private System.Windows.Forms.TextBox txt_tonggiacthd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datetime_ngaylap_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHang_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVien_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txt_maHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn traiCay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGia;
    }
}