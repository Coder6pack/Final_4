using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frm_gioHang()
        {
            InitializeComponent();
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
                case "Khách hàng đã là thành viên":
                    {
                        MessageBox.Show("Khách hàng đã là thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                case "Khách hàng không là thành viên":
                    {
                        MessageBox.Show("Khách hàng không là thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //if (khachhangBUS.themKhachHang(khachhang))
                        //{
                        //    MessageBox.Show("Khách hàng đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        return;
                    }
            }
        }

        //private void GioHang_Load(object sender, EventArgs e)
        //{
        //    dgv_dsTraiCay.DataSource = gioHangBus.loadGioHang();
        //}
    }
}
