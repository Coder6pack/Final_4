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
            hoadondtos.khachHang_id = int.Parse(txt_makhachhang_hoadon.Text);
            hoadondtos.nhanVien_id = int.Parse(txt_manhanvien_hoadon.Text);
            hoadondtos.ngayLap = DateTime.Parse(datetime_ngaylap_hoadon.Text);
            hoadondtos.thanhTien = SqlMoney.Parse(txt_thanhtien_hoadon.Text);
            hoadondtos.chietKhau = int.Parse(txt_chietkhau_hoadon.Text);
            hoadondtos.trangThai = int.Parse(txt_trangthai.Text);
        }
    }
}
