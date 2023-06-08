using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonDAL:DBAccess
    {
        public List<HoaDonDTO> loadDSHoaDon()
        {
            List<HoaDonDTO> dsHoaDon = loadHoaDonDTO();
            return dsHoaDon;
        }
        public List<HoaDonDTO> timKiemHoaDon(string maHoaDon)
        {
            List<HoaDonDTO> dshd = new List<HoaDonDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from hoaDon Where id like @id and trangThai = 0", conn);
            cmd.Parameters.AddWithValue("@id", "%" + maHoaDon + "%");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO();
                    hd.id = reader.GetInt32(0);
                    hd.khachHang_id = reader.GetInt32(1);
                    hd.nhanVien_id = reader.GetInt32(2);
                    hd.ngayLap = reader.GetDateTime(3);
                    hd.thanhTien = reader.GetSqlMoney(4);
                    hd.chietKhau = reader.GetInt32(5);
                    hd.trangThai = reader.GetInt32(6);
                    dshd.Add(hd);
                }
                reader.Close();
                conn.Close();
            }

            return dshd;
        }
        public bool themHoaDon(HoaDonDTO hoaDon)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_themHoaDon",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@khachHang_id",hoaDon.khachHang_id);
            cmd.Parameters.AddWithValue("@nhanVien_id", hoaDon.nhanVien_id);
            cmd.Parameters.AddWithValue("@ngayLap", hoaDon.ngayLap);
            cmd.Parameters.AddWithValue("@thanhTien", hoaDon.thanhTien);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool xoaHoaDon(HoaDonDTO hoadon)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE hoaDon set trangThai = 1 Where id =@id", conn);
            cmd.Parameters.AddWithValue("@id", hoadon.id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool capNhatHoaDon(HoaDonDTO hdon) 
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_capNhatHoaDon", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", hdon.id);
            cmd.Parameters.AddWithValue("@khachHang_id",hdon.khachHang_id);
            cmd.Parameters.AddWithValue("@nhanVien_id",hdon.nhanVien_id);
            cmd.Parameters.AddWithValue("@ngayLap",hdon.ngayLap);
            cmd.Parameters.AddWithValue("@thanhTien",hdon.thanhTien);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;

        }
    }
}
