using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using BUS;
using DTO;
namespace GUI
{
    public partial class frm_HoaDon : Form
    {
        public HoaDonBUS hoadonbus = new HoaDonBUS();
        public CTHoaDonBUS cthoadonbus = new CTHoaDonBUS();
        public void resetHoaDon()
        {
            txt_macthd.Text = txt_manhanvien_hoadon.Text = txt_makhachhang_hoadon.Text = txt_thanhtien_hoadon.Text = txt_chietkhau_hoadon.Text = "";
        }
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = hoadonbus.loadDSHoaDon();
            dgv_CThoadon.DataSource = cthoadonbus.loadCTHoaDon();
        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_cthd_Click(object sender, EventArgs e)
        {
        }

        private void btn_them_hoadon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoadondtos = new HoaDonDTO();
            hoadondtos.khachHang_id = int.Parse(lb_kh.Text);
            hoadondtos.nhanVien_id = int.Parse(txt_manhanvien_hoadon.Text);
            hoadondtos.ngayLap = DateTime.Parse(datetime_ngaylap_hoadon.Text);
            hoadondtos.thanhTien = SqlMoney.Parse(txt_thanhtien_hoadon.Text);
            hoadondtos.chietKhau = int.Parse(txt_chietkhau_hoadon.Text);

        }

        private void btn_capnhat_hoadon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoaDon = new HoaDonDTO();
            hoaDon.id = int.Parse(txt_maHoaDon.Text);
            hoaDon.khachHang_id = int.Parse(txt_makhachhang_hoadon.Text);
            hoaDon.nhanVien_id = int.Parse(txt_manhanvien_hoadon.Text);
            hoaDon.ngayLap = datetime_ngaylap_hoadon.Value;
            hoaDon.thanhTien = SqlMoney.Parse(txt_thanhtien_hoadon.Text);
            if (hoadonbus.capNhatHoaDon(hoaDon))
            {
                MessageBox.Show("Cập nhật đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_hoadon.DataSource = hoadonbus.loadDSHoaDon();
            }
            else
            {
                MessageBox.Show("Cập nhật đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resetHoaDon();
        }

        private void txt_manhanvien_hoadon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_hoadon.Rows[e.RowIndex];
                txt_maHoaDon.Text = row.Cells["id"].Value.ToString();
                txt_manhanvien_hoadon.Text = row.Cells["nhanVien_id"].Value.ToString();
                txt_makhachhang_hoadon.Text = row.Cells["khachHang_id"].Value.ToString();
                datetime_ngaylap_hoadon.Text = row.Cells["ngayLap"].Value.ToString();
                txt_thanhtien_hoadon.Text = row.Cells["thanhTien"].Value.ToString();
                txt_chietkhau_hoadon.Text = row.Cells["chietKhau"].Value.ToString();
            }
        }
        
        private void btn_xoa_hoadon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hdon = new HoaDonDTO();
            hdon.id = int.Parse(txt_maHoaDon.Text);
            if (hoadonbus.xoaHoaDon(hdon))
            {
                MessageBox.Show("Xoá hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_hoadon.DataSource = hoadonbus.loadDSHoaDon();
            }
            else
            {
                MessageBox.Show("Xoá hoá đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resetHoaDon();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = hoadonbus.timKiemHoaDon(txt_timKiemHoaDon.Text);
        }

        private void btn_timKiemHoaDon_Click(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = hoadonbus.timKiemHoaDon(txt_timKiemHoaDon.Text);
        }

        private void dgv_CThoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
            
                DataGridViewRow row = dgv_CThoadon.Rows[e.RowIndex];
                txt_macthd.Text = row.Cells["id_cthd"].Value.ToString();
                txt_matraicaycthd.Text = row.Cells["traiCay_id"].Value.ToString();
                txt_giacthd.Text = row.Cells["gia"].Value.ToString();
                txt_giamgiacthd.Text = row.Cells["giamGia"].Value.ToString();
                txt_tonggiacthd.Text = row.Cells["tongGia"].Value.ToString();
                txt_slcthd.Text = row.Cells["soLuong"].Value.ToString();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            dgv_CThoadon.DataSource = cthoadonbus.timKiemCTHoaDon(txt_timkiem.Text);
        }

        private void btn_timkiem_cthd_Click(object sender, EventArgs e)
        {
            dgv_CThoadon.DataSource = cthoadonbus.timKiemCTHoaDon(txt_timkiem.Text);
        }

        private void btn_xoa_cthd_Click(object sender, EventArgs e)
        {
            CTHoaDonDTO ctHoaDon = new CTHoaDonDTO();
            ctHoaDon.id = int.Parse(txt_macthd.Text);
            if(cthoadonbus.xoaCTHoaDon(ctHoaDon)) 
            {
                MessageBox.Show("Xoá chi tiết hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_hoadon.DataSource = cthoadonbus.loadCTHoaDon();
            }
            else
            {
                MessageBox.Show("Xoá chi tiết hoá đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resetHoaDon();
        }
    }
}
