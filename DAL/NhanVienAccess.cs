using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienAccess
    {
        public string checkLoginDTO(NhanVien nhanvien)
        {
            string user = null;

            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from nhanVien where taiKhoan = @taikhoan and matKhau = @matkhau", conn);
            command.Parameters.AddWithValue("@taikhoan", nhanvien.taiKhoan);
            command.Parameters.AddWithValue("@matkhau", nhanvien.matKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                    return user;
                }
                reader.Close();
                conn.Close();

            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }

            return user;
        }

        public List<NhanVien> dsNhanVienDTO()
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from NhanVien where trangThai = 0", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVien nhanvien = new NhanVien();
                    nhanvien.id = reader.GetInt32(0);
                    nhanvien.tenNhanVien = reader.GetString(1);
                    nhanvien.taiKhoan = reader.GetString(2);
                    nhanvien.matKhau = reader.GetString(3);
                    nhanvien.quyen = reader.GetString(4);
                    nhanvien.ngaySinh = reader.GetDateTime(5);
                    nhanvien.gioiTinh = reader.GetString(6);
                    nhanvien.sdt = reader.GetString(7);
                    nhanvien.diaChi = reader.GetString(8);
                    nhanvien.trangThai = reader.GetInt32(9);
                    //nhanvien.hinh = reader.GetString(10);
                    dsnv.Add(nhanvien);

                }
                reader.Close();
                conn.Close();
            }

            return dsnv;
        }

        public List<NhanVien> timKiemNhanVien(string tenNhanVien)
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from nhanVien where tenNhanVien like @tenNhanVien", conn);
            cmd.Parameters.AddWithValue("@tenNhanVien", "%" + tenNhanVien + "%");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVien nhanvien = new NhanVien();
                    nhanvien.id = reader.GetInt32(0);
                    nhanvien.tenNhanVien = reader.GetString(1);
                    nhanvien.taiKhoan = reader.GetString(2);
                    nhanvien.matKhau = reader.GetString(3);
                    nhanvien.quyen = reader.GetString(4);
                    nhanvien.ngaySinh = reader.GetDateTime(5);
                    nhanvien.gioiTinh = reader.GetString(6);
                    nhanvien.sdt = reader.GetString(7);
                    nhanvien.diaChi = reader.GetString(8);
                    nhanvien.trangThai = reader.GetInt32(9);
                    nhanvien.hinh = reader.GetString(10);
                    dsnv.Add(nhanvien);
                }

                reader.Close();
                conn.Close();
            }
            return dsnv;
        }

        public bool themNhanVien(NhanVien nhanvien)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_themNhanVien", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenNhanVien", nhanvien.tenNhanVien);
            cmd.Parameters.AddWithValue("@taiKhoan", nhanvien.taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", nhanvien.matKhau);
            cmd.Parameters.AddWithValue("@quyen", nhanvien.quyen);
            cmd.Parameters.AddWithValue("@ngaySinh", nhanvien.ngaySinh);
            cmd.Parameters.AddWithValue("@gioiTinh", nhanvien.gioiTinh);
            cmd.Parameters.AddWithValue("@sdt", nhanvien.sdt);
            cmd.Parameters.AddWithValue("@diaChi", nhanvien.diaChi);
            cmd.Parameters.AddWithValue("@trangThai", nhanvien.trangThai);
            cmd.Parameters.AddWithValue("@hinh", nhanvien.hinh);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool suaNhanVien(NhanVien nhanvien)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update nhanVien set tenNhanVien = @tenNhanVien,taiKhoan = @taiKhoan,matKhau =@matKhau,quyen=@quyen,ngaySinh = @ngaySinh,gioiTinh=@gioiTinh,sdt=@sdt,trangThai=@trangThai,hinh=@hinh Where id =@id", conn);
            cmd.Parameters.AddWithValue("@tenNhanVien", nhanvien.tenNhanVien);
            cmd.Parameters.AddWithValue("@taiKhoan", nhanvien.taiKhoan);
            cmd.Parameters.AddWithValue("@matKhau", nhanvien.matKhau);
            cmd.Parameters.AddWithValue("@quyen", nhanvien.quyen);
            cmd.Parameters.AddWithValue("@ngaySinh", nhanvien.ngaySinh);
            cmd.Parameters.AddWithValue("@gioiTinh", nhanvien.gioiTinh);
            cmd.Parameters.AddWithValue("@sdt", nhanvien.sdt);
            cmd.Parameters.AddWithValue("@diaCHi", nhanvien.diaChi);
            cmd.Parameters.AddWithValue("@trangThai", nhanvien.trangThai);
            cmd.Parameters.AddWithValue("@hinh", nhanvien.hinh);
            cmd.Parameters.AddWithValue("@id", nhanvien.id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool xoaNhanVien(NhanVien nhanvien)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update nhanVien set trangThai = 1 where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", nhanvien.id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
