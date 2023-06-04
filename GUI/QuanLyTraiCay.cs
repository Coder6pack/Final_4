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
    public partial class frm_quanLyTraiCay : Form
    {
        TraiCayBUS traicayBUS = new TraiCayBUS();
        public frm_quanLyTraiCay()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        public lo_TraiCayBUS lo_traicaybus = new lo_TraiCayBUS();
        public quanLyLoaiTraiCayBUS quanlytraicaybus = new quanLyLoaiTraiCayBUS();
        private void frm_quanLyTraiCay_Load(object sender, EventArgs e)
        {
            dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            dgv_dsTraiCay.DataSource = traicayBUS.loadTraiCay();
            dgv_bangloaitraicay.DataSource = quanlytraicaybus.loadquanLyLoaiTraiCay();
        }

        private void btn_them_lohang_Click(object sender, EventArgs e)
        {
            lo_TraiCayDTO lo_traicays = new lo_TraiCayDTO();
            lo_traicays.ngayNhap = DateTime.Parse(datetime_lohang.Text);
            if (lo_traicaybus.Themlo_TraiCay(lo_traicays))
            {
                MessageBox.Show("Thêm lô hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            {
                MessageBox.Show("Thêm lô hàng thất bại");
            }
        }

        private void dgv_lohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                DataGridViewRow row = dgv_lohang.Rows[e.RowIndex];
                txt_malohang.Text = row.Cells["MaLoTraiCay"].Value.ToString();
                datetime_lohang.Text = row.Cells["NgayNhap"].Value.ToString();
            }    
        }

        private void btn_xoa_lohang_Click(object sender, EventArgs e)
        {
            int malohang = int.Parse(txt_malohang.Text);
            if (lo_traicaybus.Xoalo_TraiCay(malohang))
            {
                MessageBox.Show("Xóa lo hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            else
            {
                MessageBox.Show("Xóa lô hàng thất bại");
            }
        }

        private void btn_capnhat_lohang_Click(object sender, EventArgs e)
        {
            lo_TraiCayDTO lo_traicays = new lo_TraiCayDTO();
            lo_traicays.id = int.Parse(txt_malohang.Text);
            lo_traicays.ngayNhap = datetime_lohang.Value;
            if (lo_traicaybus.CapNhatlo_TraiCay(lo_traicays))
            {
                MessageBox.Show("Cập Nhật lô hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            else
            {
                MessageBox.Show("Cập nhật lô hàng thất bại");
            }
        }

        private void btn_timkiem_lohang_Click(object sender, EventArgs e)
        {
           int maso = int.Parse(txt_matimkiem.Text);
            dgv_lohang.DataSource = lo_traicaybus.TimkiemloTraiCay(maso);
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
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
                ptc_anhTraiCay.Image = Image.FromFile(filePath);
            }
        }

        private void dgv_dsTraiCay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsTraiCay.Rows[e.RowIndex];
                txt_id.Text = row.Cells["id"].Value.ToString();
                txt_loaiTraiCay_id.Text = row.Cells["loaiTraiCay_id"].Value.ToString();
                txt_loTraiCay_id.Text = row.Cells["loTraiCay_id"].Value.ToString();
                txt_tenTraiCay.Text = row.Cells["tenTraiCay"].Value.ToString();
                txt_gia.Text = row.Cells["gia"].Value.ToString();
                txt_soLuong.Text = row.Cells["soLuong"].Value.ToString();
                txt_HSD.Text = row.Cells["HSD"].Value.ToString();
                txt_trangThai.Text = row.Cells["trangThai"].Value.ToString();
                txt_hinh.Text = row.Cells["hinh"].Value.ToString();
                try
                {
                    ptc_anhTraiCay.Image = Image.FromFile(@"hinhanh\" + row.Cells["hinh"].Value.ToString());

                }
                catch (Exception ex)
                {
                    ptc_anhTraiCay.Image = Image.FromFile(@"hinhanh\warning.jpg");
                }
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            TraiCayDTO traicay = new TraiCayDTO();
            traicay.id = int.Parse(txt_id.Text);
            traicay.loaiTraiCay_id = int.Parse(txt_loaiTraiCay_id.Text);
            traicay.loTraiCay_id = int.Parse(txt_loTraiCay_id.Text);
            traicay.tenTraiCay = txt_tenTraiCay.Text;
            traicay.gia = SqlMoney.Parse(txt_gia.Text);
            traicay.soLuong = int.Parse(txt_soLuong.Text);
            traicay.HSD = DateTime.Parse(txt_HSD.Text);
            traicay.trangThai = int.Parse(txt_trangThai.Text);
            traicay.hinh = txt_hinh.Text;
            string path = @"hinhanh\" + txt_hinh.Text;
            if (File.Exists(path))
            {
                Image img = null;
                using (Image image = Image.FromFile(path))
                {
                    ptc_anhTraiCay.Image?.Dispose();
                    ptc_anhTraiCay.Image = new Bitmap(image);
                    img = new Bitmap(image);
                }
                File.Delete(path);
                img.Save(path);
            }
            else
            {
                MessageBox.Show(path);
                ptc_anhTraiCay.Image.Save(path);
            }
            if (traicayBUS.suaTraiCay(traicay))
            {
                MessageBox.Show("Cập nhật thành công");
                dgv_dsTraiCay.DataSource = traicayBUS.loadTraiCay();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            TraiCayDTO traicay = new TraiCayDTO();
            traicay.loaiTraiCay_id = int.Parse(txt_loaiTraiCay_id.Text);
            traicay.loTraiCay_id = int.Parse(txt_loTraiCay_id.Text);
            traicay.tenTraiCay = txt_tenTraiCay.Text;
            traicay.gia = SqlMoney.Parse(txt_gia.Text);
            traicay.soLuong = int.Parse(txt_soLuong.Text);
            traicay.HSD = DateTime.Parse(txt_HSD.Text);
            traicay.trangThai = int.Parse(txt_trangThai.Text);
            traicay.hinh = txt_hinh.Text;
            string path = @"hinhanh\" + txt_hinh.Text;
            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show("Hình đã tồn tại", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            if (traicayBUS.themTraiCay(traicay))
            {
                ptc_anhTraiCay.Image.Save(@"hinhanh\" + txt_hinh.Text);
                MessageBox.Show("Thêm trái cây thành công");
                dgv_dsTraiCay.DataSource = traicayBUS.loadTraiCay();
            }
            else
            {
                MessageBox.Show("Thêm trái cây thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            TraiCayDTO traicay = new TraiCayDTO();
            traicay.id = int.Parse(txt_id.Text);
            if (traicayBUS.themTraiCay(traicay))
            {
                MessageBox.Show("Xoá trái cây thành công");
                dgv_dsTraiCay.DataSource = traicayBUS.loadTraiCay();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void txt_timKiem_TextChanged_1(object sender, EventArgs e)
        {
            dgv_dsTraiCay.DataSource = traicayBUS.timKiemTraiCay(txt_timKiem.Text);
        }

        private void dgv_bangloaitraicay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_bangloaitraicay.Rows[e.RowIndex];
                txt_maloaitraicay.Text = row.Cells["maloai"].Value.ToString();
                txt_tenloaitraicay.Text = row.Cells["tenloaitraicay"].Value.ToString();
                txt_trangthailoaitraicay.Text = row.Cells["trangthailoai"].Value.ToString();
            }
        }

        private void btn_them_loai_Click(object sender, EventArgs e)
        {
            quanLyLoaiTraiCay lo_traicays = new quanLyLoaiTraiCay();
            lo_traicays.tenLoaiTraiCay = txt_tenloaitraicay.Text;
            lo_traicays.trangThai = int.Parse(txt_trangthailoaitraicay.Text);
            if (quanlytraicaybus.ThemloaiTraiCay(lo_traicays))
            {
                MessageBox.Show("Thêm loại trái cây thành công");
                quanlytraicaybus.loadquanLyLoaiTraiCay();
                dgv_bangloaitraicay.DataSource = quanlytraicaybus.loadquanLyLoaiTraiCay();
            }
            else
            {
                MessageBox.Show("Thêm loại trái cây thất bại");
            }
        }

        private void btn_xoa_loai_Click(object sender, EventArgs e)
        {
            int maloaitraicay = int.Parse(txt_maloaitraicay.Text);
            if (quanlytraicaybus.XoaloaiTraiCay(maloaitraicay))
            {
                MessageBox.Show("Xóa loại trái cây thành công");
                quanlytraicaybus.loadquanLyLoaiTraiCay();
                dgv_bangloaitraicay.DataSource = quanlytraicaybus.loadquanLyLoaiTraiCay();
            }
            else
            {
                MessageBox.Show("Xóa loại trái cây thất bại");
            }
        }

        private void btn_capnhatloai_Click(object sender, EventArgs e)
        {
            quanLyLoaiTraiCay lo_traicays = new quanLyLoaiTraiCay();
            lo_traicays.id = int.Parse(txt_maloaitraicay.Text);
            lo_traicays.tenLoaiTraiCay = txt_tenloaitraicay.Text;
            lo_traicays.trangThai = int.Parse(txt_trangthailoaitraicay.Text);
            if (quanlytraicaybus.CapNhatloaiTraiCay(lo_traicays))
            {
                MessageBox.Show("Cập Nhật lô hàng thành công");
                quanlytraicaybus.loadquanLyLoaiTraiCay();
                dgv_bangloaitraicay.DataSource = quanlytraicaybus.loadquanLyLoaiTraiCay();
            }
            else
            {
                MessageBox.Show("Cập nhật lô hàng thất bại");
            }
        }

        private void btn_tim_loai_Click(object sender, EventArgs e)
        {
            dgv_bangloaitraicay.DataSource = quanlytraicaybus.TimkiemloaiTraiCay(int.Parse(txt_timkiem_loai.Text));
        }
    }
}
