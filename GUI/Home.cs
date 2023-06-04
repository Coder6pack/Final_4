using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final3
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        // Tạo đối tượng form con
        private Form currentFormChild;

        // Hàm gọi form con lên from cha
        private void openFormChid(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_body.Controls.Add(childForm);
            pn_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            openFormChid(new frm_gioHang(this.id));
            lbl_maNhanVien.Text = this.id;
            lbl_tenNhanVien.Text = this.tenNhanVien;

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (quyen == "Quản lý")
            {
                openFormChid(new frm_nhanVien());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này !!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_gioHang_Click(object sender, EventArgs e)
        {
            openFormChid(new frm_gioHang());
        }

        private void btn_hoaDon_Click(object sender, EventArgs e)
        {
            if (quyen == "Quản lý")
            {
                openFormChid(new frm_HoaDon());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này !!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            if (quyen == "Quản lý")
            {
                openFormChid(new frm_quanLyTraiCay());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này !!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        string id = "", tenNhanVien = "", taiKhoan = "", matKhau = "", quyen = "";
        public frm_home(string id, string tenNhanVien, string taiKhoan, string matKhau, string quyen)
        {
            InitializeComponent();
            this.id = id;
            this.tenNhanVien = tenNhanVien;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }


    }
}
