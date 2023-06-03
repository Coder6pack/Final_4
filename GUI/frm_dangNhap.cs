using BUS;
using DTO;
using Final3;
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
    public partial class frm_dangNhap : Form
    {
        NhanVien nhanvien = new NhanVien();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public frm_dangNhap()
        {
            InitializeComponent();
        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {
        }

 

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            nhanvien.taiKhoan = txt_taiKhoan.Text;
            nhanvien.matKhau = txt_matKhau.Text;
            string getUser = nhanvienBUS.checkLogin(nhanvien);

            switch (getUser)
            {
                case "requireAccount": { MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                case "requirePassword": { MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                case "Tài khoản hoặc mật khẩu không chính xác": { MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_home home = new frm_home();
            home.ShowDialog();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
