using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Final3
{
    public partial class frm_nhanVien : Form
    {
        public NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public CT_LuongBUS ctLuongBUS = new CT_LuongBUS();
        public frm_nhanVien()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_nhanVien_Load(object sender, EventArgs e)
        {
            dgv_nhanVien.DataSource = nhanvienBUS.dsNhanVien();
            dgv_ctLuong.DataSource = ctLuongBUS.loadDSLuong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_nhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nhanVien.Rows[e.RowIndex];
                txt_maNhanVien.Text = row.Cells["id"].Value.ToString();
                txt_tenNhanVien.Text = row.Cells["tenNhanVien"].Value.ToString();
                dtp_ngaySinh.Text = row.Cells["ngaySinh"].Value.ToString();
                txt_gioiTinh.Text = row.Cells["gioiTinh"].Value.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value.ToString();
                txt_diaChi.Text = row.Cells["diaChi"].Value.ToString();
                txt_taiKhoan.Text = row.Cells["taiKhoan"].Value.ToString();
                txt_matKhau.Text = row.Cells["matKhau"].Value.ToString();
                txt_chucVu.Text = row.Cells["quyen"].Value.ToString();
                txt_hinh.Text = row.Cells["hinh"].Value.ToString();
                txt_trangThai.Text = row.Cells["trangThai"].Value.ToString();

                try
                {
                    ptc_anhNhanVien.Image = Image.FromFile(@"hinhanh\" + row.Cells["hinh"].Value.ToString());

                }
                catch (Exception ex)
                {
                    ptc_anhNhanVien.Image = Image.FromFile(@"hinhanh\warning.jpg");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files (*.jpg) |*.jpg |PNG files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Lấy đường dẫn
                string filePath = openFileDialog.FileName;
                txt_hinh.Text = Path.GetFileName(filePath);
                ptc_anhNhanVien.Image = Image.FromFile(filePath);
            }
        }
        //Ham reset thông tin
        private void resetInfor()
        {
            txt_maNhanVien.Text = "";
            txt_tenNhanVien.Text = "";
            dtp_ngaySinh.Text = "";
            txt_gioiTinh.Text = "";
            txt_sdt.Text = "";
            txt_diaChi.Text = "";
            txt_taiKhoan.Text = "";
            txt_matKhau.Text = "";
            txt_chucVu.Text = "";
            txt_hinh.Text = "";
            txt_trangThai.Text = "";
        }


        private void btn_reset_nhanVien_Click(object sender, EventArgs e)
        {
            resetInfor();
        }


        private void btn_them_nhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.tenNhanVien = txt_tenNhanVien.Text;
            nhanvien.taiKhoan = txt_taiKhoan.Text;
            nhanvien.matKhau = txt_matKhau.Text;
            nhanvien.quyen = txt_chucVu.Text;
            nhanvien.ngaySinh = dtp_ngaySinh.Value;
            nhanvien.gioiTinh = txt_gioiTinh.Text;
            nhanvien.sdt = txt_sdt.Text;
            nhanvien.diaChi = txt_diaChi.Text;
            nhanvien.trangThai = int.Parse(txt_trangThai.Text);
            nhanvien.hinh = txt_hinh.Text;
            string path = @"hinhanh\" + txt_hinh.Text;
            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show("Hình đã tồn tại", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            if (nhanvienBUS.themNhanVien(nhanvien))
            {
                ptc_anhNhanVien.Image.Save(@"hinhanh\" + txt_hinh.Text);
                MessageBox.Show("Thêm nhân viên thành công");
                dgv_nhanVien.DataSource = nhanvienBUS.dsNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }

        }

        private void btn_capNhat_nhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.id = int.Parse(txt_maNhanVien.Text);
            nhanvien.tenNhanVien = txt_tenNhanVien.Text;
            nhanvien.taiKhoan = txt_taiKhoan.Text;
            nhanvien.matKhau = txt_matKhau.Text;
            nhanvien.quyen = txt_chucVu.Text;
            nhanvien.ngaySinh = dtp_ngaySinh.Value;
            nhanvien.gioiTinh = txt_gioiTinh.Text;
            nhanvien.sdt = txt_sdt.Text;
            nhanvien.diaChi = txt_diaChi.Text;
            nhanvien.trangThai = int.Parse(txt_trangThai.Text);
            nhanvien.hinh = txt_hinh.Text;
            string path = @"hinhanh\" + txt_hinh.Text;
            if (File.Exists(path))
            {
                Image img = null;
                using (Image image = Image.FromFile(path))
                {
                    ptc_anhNhanVien.Image?.Dispose();
                    ptc_anhNhanVien.Image = new Bitmap(image);
                    img = new Bitmap(image);
                }
                File.Delete(path);
                img.Save(path);
            }
            else
            {
                MessageBox.Show(path);
                ptc_anhNhanVien.Image.Save(path);
            }
            if (nhanvienBUS.suaNhanVien(nhanvien))
            {
                MessageBox.Show("Cập nhật thành công");
                dgv_nhanVien.DataSource = nhanvienBUS.dsNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_nhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.id = int.Parse(txt_maNhanVien.Text);
            if (nhanvienBUS.xoaNhanVien(nhanvien))
            {
                MessageBox.Show("Xoá thành công");
                resetInfor();
                dgv_nhanVien.DataSource = nhanvienBUS.dsNhanVien();
            }
            else
            {
                MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            dgv_nhanVien.DataSource = nhanvienBUS.timNhanVien(txt_timKiem.Text);
        }

        private void btn_timKiem_nhanVien_Click(object sender, EventArgs e)
        {
            dgv_nhanVien.DataSource = nhanvienBUS.timNhanVien(txt_timKiem.Text);
        }

        private void dgv_ctLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ctLuong.Rows[e.RowIndex];
                txt_maLuong.Text = row.Cells["luong_id"].Value.ToString();
                txt_maNhanVien_ctLuong.Text = row.Cells["nhanVien_id"].Value.ToString();
                txt_luong.Text = row.Cells["luong"].Value.ToString();
                txt_gioDangNhap.Text = row.Cells["gioDangNhap"].Value.ToString();
                txt_thangNam.Text = row.Cells["thangNam"].Value.ToString();
                txt_tongLuong.Text = row.Cells["tongLuong"].Value.ToString();
            }
        }

        private void txt_timKiem_CTL_TextChanged(object sender, EventArgs e)
        {
            dgv_ctLuong.DataSource = ctLuongBUS.timKiemCT_Luong(txt_timKiem_CTL.Text);
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_luong.Text.Trim()) && !string.IsNullOrEmpty(txt_gioDangNhap.Text.Trim()))
            {
                SqlMoney tl = SqlMoney.Parse(txt_tongLuong.Text);
                SqlMoney luong = SqlMoney.Parse(txt_luong.Text);
                int gio = int.Parse(txt_gioDangNhap.Text);
                tl = luong * gio;
                txt_tongLuong.Text = tl.ToString();
            }
            else
            {
                txt_tongLuong.Text = "0";
            }
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tongLuong.Text.Trim()))
            {
                SqlMoney tl = SqlMoney.Parse(txt_tongLuong.Text);
                SqlMoney luong = SqlMoney.Parse(txt_luong.Text);
                int gio;
                if (!string.IsNullOrEmpty(txt_luong.Text.Trim()) && !string.IsNullOrEmpty(txt_gioDangNhap.Text.Trim()))
                {
                    gio = int.Parse(txt_gioDangNhap.Text);
                    tl = luong * gio;
                    txt_tongLuong.Text = tl.ToString();
                }
                else
                {
                    txt_tongLuong.Text = "0";
                }
            }
        }

        private void txt_gioDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tongLuong.Text.Trim()))
            {
                SqlMoney tl = SqlMoney.Parse(txt_tongLuong.Text);
                SqlMoney luong = SqlMoney.Parse(txt_luong.Text);
                int gio;
                if (!string.IsNullOrEmpty(txt_gioDangNhap.Text.Trim()) && !string.IsNullOrEmpty(txt_gioDangNhap.Text.Trim()))
                {
                    gio = int.Parse(txt_gioDangNhap.Text);
                    tl = luong * gio;
                    txt_tongLuong.Text = tl.ToString();
                }
                else
                {
                    txt_tongLuong.Text = "0";

                }
            }
        }

        private void txt_tongLuong_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
