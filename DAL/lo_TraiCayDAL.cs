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
    public class lo_TraiCayDAL:DBAccess
    {
        public List<lo_TraiCayDTO> loadlo_TraiCay()
        {
            List<lo_TraiCayDTO> lotrai_cay = loadlo_TraiCayDTO();
            return lotrai_cay;
        }
        public bool Themlo_TraiCay(lo_TraiCayDTO lotraicaythem)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO lo_TraiCay VALUES(@ngayNhap)", conn);
            command.Parameters.AddWithValue("@ngayNhap", lotraicaythem.ngayNhap);
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }

        public bool Xoalo_TraiCay(int malohangg)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM lo_TraiCay Where id=@id", conn);
            command.Parameters.AddWithValue("@id", malohangg);   
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }

        public bool CapNhatlo_TraiCay(lo_TraiCayDTO lotraicaycapnhat)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE lo_TraiCay SET ngayNhap=@ngayNhap Where id=@id", conn);
            command.Parameters.AddWithValue("@id", lotraicaycapnhat.id);
            command.Parameters.AddWithValue("@ngayNhap", lotraicaycapnhat.ngayNhap);
            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowAffected > 0;
        }
        public List<lo_TraiCayDTO> TimkiemloTraiCay(int MaLoHang)
        {
            List<lo_TraiCayDTO> dsltraicay = new List<lo_TraiCayDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM lo_TraiCay Where id = @id", conn);
            command.Parameters.AddWithValue("@id",MaLoHang);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lo_TraiCayDTO lotraicaydto = new lo_TraiCayDTO();
                lotraicaydto.id = reader.GetInt32(0);
                lotraicaydto.ngayNhap = reader.GetDateTime(1);
                dsltraicay.Add(lotraicaydto);
            }
            reader.Close();
            conn.Close();
            return dsltraicay;
        }
    }
}
