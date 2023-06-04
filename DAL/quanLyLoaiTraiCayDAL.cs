using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class quanLyLoaiTraiCayDAL:DBAccess
    {
        public List<quanLyLoaiTraiCay> loadquanLyTraiCay()
        {
            List<quanLyLoaiTraiCay> quanLyLoaiTraiCays = loadquanLyTraiCayDTO();
            return quanLyLoaiTraiCays;
        }
        public bool ThemloaiTraiCay(quanLyLoaiTraiCay quanLyLoaiTraiCaythem)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO quanLyLoaiTraiCay VALUES(@tenLoaiTraiCay,@trangThai)", conn);
            command.Parameters.AddWithValue("@tenLoaiTraiCay", quanLyLoaiTraiCaythem.tenLoaiTraiCay);
            command.Parameters.AddWithValue("@trangThai", quanLyLoaiTraiCaythem.trangThai);
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }

        public bool XoaloaiTraiCay(int matraicay)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM quanLyLoaiTraiCay Where id=@id", conn);
            command.Parameters.AddWithValue("@id", matraicay);
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }

        public bool CapNhatloaiTraiCay(quanLyLoaiTraiCay quanLyLoaiTraiCaycapnhat)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE lo_TraiCay SET tenLoaiTraiCay=@tenLoaiTraiCay,trangThai=@trangThai Where id=@id", conn);
            command.Parameters.AddWithValue("@id", quanLyLoaiTraiCaycapnhat.id);
            command.Parameters.AddWithValue("@tenLoaiTraiCay", quanLyLoaiTraiCaycapnhat.tenLoaiTraiCay);
            command.Parameters.AddWithValue("@trangThai", quanLyLoaiTraiCaycapnhat.trangThai);
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }
        public List<quanLyLoaiTraiCay> TimkiemloaiTraiCay(int idloaiTraiCay)
        {
            List<quanLyLoaiTraiCay> quanlyloai_traicay = new List<quanLyLoaiTraiCay>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM lo_TraiCay Where id = @id", conn);
            command.Parameters.AddWithValue("@id", idloaiTraiCay);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                quanLyLoaiTraiCay quanlyloaitraicay = new quanLyLoaiTraiCay();
                quanlyloaitraicay.id = reader.GetInt32(0);
                quanlyloaitraicay.tenLoaiTraiCay = reader.GetString(1);
                quanlyloaitraicay.trangThai = reader.GetInt32(2);
                quanlyloai_traicay.Add(quanlyloaitraicay);
            }
            reader.Close();
            conn.Close();
            return quanlyloai_traicay;
        }
    }
}
