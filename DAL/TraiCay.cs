using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TraiCay
    {
        public List<TraiCayDTO> loadTraiCay()
        {
            List<TraiCayDTO> dsGioHang = new List<TraiCayDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from quanLyTraiCay WHERE trangThai = 0", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TraiCayDTO traiCay = new TraiCayDTO();
                    traiCay.id = reader.GetInt32(0);
                    traiCay.loaiTraiCay_id = reader.GetInt32(1);
                    traiCay.loTraiCay_id = reader.GetInt32(2);
                    traiCay.tenTraiCay = reader.GetString(3);
                    traiCay.gia = reader.GetSqlMoney(4);
                    traiCay.soLuong = reader.GetInt32(5);
                    traiCay.HSD = reader.GetDateTime(6);
                    traiCay.trangThai = reader.GetInt32(7);
                    //traiCay.hinh = reader.GetString(8);
                    dsGioHang.Add(traiCay);

                }
                reader.Close();
                conn.Close();
            }

            return dsGioHang;
        }

        public List<TraiCayDTO> timKiemTraiCay(string tenTraiCay)
        {
            List<TraiCayDTO> dsTimKiem = new List<TraiCayDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From quanLyTraiCay Where tenTraiCay like @tenTraiCay", conn);
            cmd.Parameters.AddWithValue("@tenTraiCay","%"+tenTraiCay+"%");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TraiCayDTO traiCay = new TraiCayDTO();
                    traiCay.id = reader.GetInt32(0);
                    traiCay.loaiTraiCay_id = reader.GetInt32(1);
                    traiCay.loTraiCay_id = reader.GetInt32(2);
                    traiCay.tenTraiCay = reader.GetString(3);
                    traiCay.gia = reader.GetSqlMoney(4);
                    traiCay.soLuong = reader.GetInt32(5);
                    traiCay.HSD = reader.GetDateTime(6);
                    traiCay.trangThai = reader.GetInt32(7);
                    traiCay.hinh = reader.GetString(8);
                    dsTimKiem.Add(traiCay);
                }
                reader.Close();
                conn.Close();
            }

            return dsTimKiem;
        }
        public bool suaTraiCay(TraiCayDTO traicay)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_suaTraiCay", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",traicay.id);
            cmd.Parameters.AddWithValue("@loaiTraiCay_id", traicay.loaiTraiCay_id);
            cmd.Parameters.AddWithValue("@loTraiCay_id", traicay.loTraiCay_id);
            cmd.Parameters.AddWithValue("@tenTraiCay", traicay.tenTraiCay);
            cmd.Parameters.AddWithValue("@gia", traicay.gia);
            cmd.Parameters.AddWithValue("@soLuong", traicay.soLuong);
            cmd.Parameters.AddWithValue("@HSD", traicay.HSD);
            cmd.Parameters.AddWithValue("@trangThai", traicay.trangThai);
            cmd.Parameters.AddWithValue("@hinh", traicay.hinh);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
        public bool themTraiCay(TraiCayDTO traicay)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_themTraiCay", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loaiTraiCay_id", traicay.loaiTraiCay_id);
            cmd.Parameters.AddWithValue("@loTraiCay_id", traicay.loTraiCay_id);
            cmd.Parameters.AddWithValue("@tenTraiCay", traicay.tenTraiCay);
            cmd.Parameters.AddWithValue("@gia", traicay.gia);
            cmd.Parameters.AddWithValue("@soLuong", traicay.soLuong);
            cmd.Parameters.AddWithValue("@HSD", traicay.HSD);
            cmd.Parameters.AddWithValue("@trangThai", traicay.trangThai);
            cmd.Parameters.AddWithValue("@hinh", traicay.hinh);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool xoaTraiCay(TraiCayDTO traicay)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE quanLyTraiCay SET trangThai = 1 WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", traicay.id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
