using BUS;
using DTO;
using Final3;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final3
{
    public partial class frm_dangNhap : Form
    {
        NhanVien nhanvienDangNhap = new NhanVien();
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public frm_dangNhap()
        {
            InitializeComponent();
        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {
        }

 

        public void btn_dangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=quan_trai_cay;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from nhanVien where taiKhoan = N'" + txt_taiKhoan.Text + "' and matKhau = N'" + txt_matKhau.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            nhanvienDangNhap.taiKhoan = txt_taiKhoan.Text;
            nhanvienDangNhap.matKhau = txt_matKhau.Text;
            string getUser = nhanvienBUS.checkLogin(nhanvienDangNhap);

            switch (getUser)
            {
                case "requireAccount": { MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                case "requirePassword": { MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                case "Tài khoản hoặc mật khẩu không chính xác": { MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_home home = new frm_home(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
            home.ShowDialog();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
