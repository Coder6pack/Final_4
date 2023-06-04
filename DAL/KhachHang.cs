using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhachHang
    {
        public string checkKhachHang(KhachHangDTO khachhang)
        {
            string kh = null;
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from khachHang Where sdt like @sdt and tenKhachHang like @tenKhachHang",conn);
            cmd.Parameters.AddWithValue("@sdt","%" + khachhang.sdt +"%");
            cmd.Parameters.AddWithValue("@tenKhachHang", "%" +khachhang.tenKhachHang +"%" );
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    kh = reader.GetInt32(0).ToString();
                    return kh;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Khách hàng không là thành viên";
            }

            return kh;
                
        }

        public bool themKhachHang(KhachHangDTO khachHang)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO khachHang VALUES(@tenKhachHang,@sdt)", conn);
            cmd.Parameters.AddWithValue("@sdt", khachHang.sdt);
            cmd.Parameters.AddWithValue("@tenKhachHang", khachHang.tenKhachHang);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
