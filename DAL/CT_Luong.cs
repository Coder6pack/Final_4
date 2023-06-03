using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_Luong : DBAccess
    {
        public List<CT_LuongDTO> loadCT_LuongDTO()
        {
            List<CT_LuongDTO> ctluong = new List<CT_LuongDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from CT_Luong", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CT_LuongDTO ct_luong = new CT_LuongDTO();
                    ct_luong.id = reader.GetInt32(0);
                    ct_luong.nhanVien_id = reader.GetInt32(1);
                    ct_luong.luong = reader.GetSqlMoney(2);
                    ct_luong.gioDangNhap = reader.GetInt32(3);
                    ct_luong.thang_Nam = reader.GetString(4);
                    ct_luong.tongLuong = reader.GetDecimal(5);
                    ctluong.Add(ct_luong);
                }

            }

            return ctluong;
        }
        public List<CT_LuongDTO> timKiemCTLuong(string tenCTLuong)
        {
            List<CT_LuongDTO> dsctl = new List<CT_LuongDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from CT_Luong where id like @id", conn);
            cmd.Parameters.AddWithValue("@id", "%" + tenCTLuong + "%");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CT_LuongDTO ct_luong = new CT_LuongDTO();
                    ct_luong.id = reader.GetInt32(0);
                    ct_luong.nhanVien_id = reader.GetInt32(1);
                    ct_luong.luong = reader.GetSqlMoney(2);
                    ct_luong.gioDangNhap = reader.GetInt32(3);
                    ct_luong.thang_Nam = reader.GetString(4);
                    ct_luong.tongLuong = reader.GetDecimal(5);
                    dsctl.Add(ct_luong);
                }

                reader.Close();
                conn.Close();
            }
            return dsctl;
        }

        public bool themCTLuong(CT_LuongDTO ctluong)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_themCTLuong", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhanVien_id", ctluong.nhanVien_id);
            cmd.Parameters.AddWithValue("@luong", ctluong.luong);
            cmd.Parameters.AddWithValue("@gioDangNhap", ctluong.gioDangNhap);
            cmd.Parameters.AddWithValue("@thang_Nam", ctluong.thang_Nam);
            cmd.Parameters.AddWithValue("@tongLuong", ctluong.tongLuong);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool capNhatCTLuong(CT_LuongDTO ctluong)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_capNhatCTLuong", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", ctluong.id);
            cmd.Parameters.AddWithValue("@nhanVien_id", ctluong.nhanVien_id);
            cmd.Parameters.AddWithValue("@luong", ctluong.luong);
            cmd.Parameters.AddWithValue("@gioDangNhap", ctluong.gioDangNhap);
            cmd.Parameters.AddWithValue("@thang_Nam", ctluong.thang_Nam);
            cmd.Parameters.AddWithValue("@tongLuong", ctluong.tongLuong);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
