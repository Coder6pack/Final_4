﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_gioHang : Form
    {
        GioHangTraiCayBUS gioHangBus = new GioHangTraiCayBUS();
        CTHoaDonBUS ctHoaDonBUS = new CTHoaDonBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public frm_gioHang()
        {
            InitializeComponent();
            txt_sdt.Text = "Lâm Hoài Nhơn";
            txt_tenKH.Text = "0899445790";
        }
        string ids = "";
        public frm_gioHang(string ids)
        {
            InitializeComponent();
            this.ids = ids;
            txt_sdt.Text = "Lâm Hoài Nhơn";
            txt_tenKH.Text = "0899445790";

        }
        private void frm_gioHang_Load(object sender, EventArgs e)
        {
            dgv_dsTraiCay.DataSource = gioHangBus.loadGioHang();
            lb_giamGia.Text = lb_tamTinh.Text = lb_thue.Text = lb_tongGia.Text = "";
        }

        private void dgv_dsTraiCay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsTraiCay.Rows[e.RowIndex];
                txt_tenTraiCay.Text = row.Cells["tenTraiCay"].Value.ToString();
                txt_maTraiCay.Text = row.Cells["id"].Value.ToString();
                txt_donGia.Text = row.Cells["gia"].Value.ToString();
                if(int.Parse(row.Cells["trangThai"].Value.ToString()) == 0)
                {
                    txt_HSD.Text = "Còn hạn";
                }
                else
                {
                    txt_HSD.Text = "Hết hạn";
                }
                txt_giamGia.Text = "1000.00";
                txt_lo.Text = row.Cells["loTraiCay_id"].Value.ToString();
                try
                {
                    ptb_anhTraiCay.Image = Image.FromFile(@"hinhanh\" + row.Cells["hinh"].Value.ToString());

                }
                catch (Exception ex)
                {
                    ptb_anhTraiCay.Image = Image.FromFile(@"hinhanh\warning.jpg");
                }
            }
        }
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        string khachHang_ids = "";
        private void btn_kiemTra_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachhang = new KhachHangDTO();
            khachhang.sdt = txt_sdt.Text;
            khachhang.tenKhachHang = txt_tenKH.Text;
            string getKhachHang = khachhangBUS.checkKhachHang(khachhang);
            switch (getKhachHang)
            {

                case "requireNameCustomer":
                    {
                        MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                case "requireCustomer":
                    {
                        MessageBox.Show("Chưa nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                case "Khách hàng không là thành viên":
                    {
                        MessageBox.Show("Khách hàng không là thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult result = MessageBox.Show("Bạn có muốn thêm khách hàng","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (khachhangBUS.themKhachHang(khachhang))
                            {
                                MessageBox.Show("Khách hàng đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                        return;
                    }
                    
            }
            MessageBox.Show("Khách hàng đã là thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            khachHang_ids = getKhachHang;
        }

        public void clearText()
        {
            txt_maTraiCay.Text = txt_donGia.Text = txt_giamGia.Text = txt_tenTraiCay.Text = txt_lo.Text = txt_HSD.Text = "";
            nud_soLuong.Value = 1;
        }
        SqlMoney tamTinh = 0;
        SqlMoney thanhTien = 0;
        SqlMoney giamGia_thanhTien = 0;
 

        private void btn_them_Click(object sender, EventArgs e)
        {
        
            SqlMoney tongGia= new SqlMoney();
            tongGia = SqlMoney.Parse(txt_donGia.Text)*nud_soLuong.Value -SqlMoney.Parse(txt_giamGia.Text);
            dgv_dsDonHang.Rows.Add(txt_maTraiCay.Text, txt_donGia.Text, nud_soLuong.Value.ToString(), txt_giamGia.Text, tongGia.ToString());
            tamTinh += SqlMoney.Parse(txt_donGia.Text);
            giamGia_thanhTien += SqlMoney.Parse(txt_giamGia.Text);
            thanhTien += SqlMoney.Parse(txt_donGia.Text) * SqlMoney.Parse("0.98") - SqlMoney.Parse(txt_giamGia.Text);
            clearText();
            lb_tamTinh.Text = tamTinh.ToString();
            lb_giamGia.Text = giamGia_thanhTien.ToString();
            lb_thue.Text = "2%";
            lb_tongGia.Text = thanhTien.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_dsDonHang.CurrentCell.RowIndex;
            if (dgv_dsDonHang.SelectedRows.Count == 0)
            {
                DataGridViewRow row = dgv_dsDonHang.Rows[rowIndex];
                tamTinh -= SqlMoney.Parse(row.Cells["gia_cthd"].Value.ToString());
                giamGia_thanhTien -= SqlMoney.Parse(row.Cells["giamGia"].Value.ToString());
                thanhTien -= SqlMoney.Parse(row.Cells["gia_cthd"].Value.ToString()) * SqlMoney.Parse("0.98") - SqlMoney.Parse((row.Cells["giamGia"].Value.ToString()));
                lb_thue.Text = "2%";
            }

            lb_tamTinh.Text = tamTinh.ToString();
            lb_giamGia.Text = giamGia_thanhTien.ToString();
            lb_tongGia.Text = thanhTien.ToString();

            if (rowIndex >=0 )
            {
                dgv_dsDonHang.Rows.RemoveAt(rowIndex);
                
            }

        }
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            // Hoá đơn
            HoaDonDTO hoaDon = new HoaDonDTO();
            hoaDon.khachHang_id = int.Parse(khachHang_ids);
            hoaDon.nhanVien_id = int.Parse(ids);
            hoaDon.ngayLap = dtp_ngayLap.Value;
            hoaDon.thanhTien = thanhTien;

            // Chi tiết hoá đơn
            //if (hoaDonBUS.ThemHoaDon(hoaDon))
            //{
            //    MessageBox.Show("Đã thanh toán hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            for (int i = 0; i < dgv_dsDonHang.Rows.Count-1; i++)
            {
                CTHoaDonDTO cthd = new CTHoaDonDTO();
                MessageBox.Show(dgv_dsDonHang.Rows[i].Cells[0].Value.ToString(), "Ten");
                cthd.traiCay_id = int.Parse(dgv_dsDonHang.Rows[i].Cells[0].Value.ToString());
                cthd.gia = SqlMoney.Parse(dgv_dsDonHang.Rows[i].Cells[1].Value.ToString());
                cthd.soLuong = int.Parse(dgv_dsDonHang.Rows[i].Cells[2].Value.ToString());
                cthd.giamGia = SqlMoney.Parse(dgv_dsDonHang.Rows[i].Cells[3].Value.ToString());
                cthd.tongGia = SqlMoney.Parse(dgv_dsDonHang.Rows[i].Cells[4].Value.ToString());
                if (ctHoaDonBUS.themCTHoaDon(cthd))
                {
                    MessageBox.Show("Done", "Thong bao");
                }
            }
        }

        //private void GioHang_Load(object sender, EventArgs e)
        //{
        //    dgv_dsTraiCay.DataSource = gioHangBus.loadGioHang();
        //}
    }
}
