using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CTHoaDonDAL:DBAccess
    {
        public List<CTHoaDonDTO> loadCTHoaDon()
        {
            List<CTHoaDonDTO> dsCTHOADON = loadCTHoaDonDTO();
            return dsCTHOADON;
        }

        public bool themCTHoaDon(CTHoaDonDTO cthd)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("pro_themCT_HoaDon", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@traiCay_id",cthd.traiCay_id);
            cmd.Parameters.AddWithValue("@gia",cthd.gia);
            cmd.Parameters.AddWithValue("@soLuong",cthd.soLuong);
            cmd.Parameters.AddWithValue("@giamGia",cthd.giamGia);
            cmd.Parameters.AddWithValue("@tongGia",cthd.tongGia);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool xoaCTHoaDon(CTHoaDonDTO cthd)
        {
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from CT_HoaDon Where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", cthd.id);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public List<CTHoaDonDTO> timKiemCTHoaDon(string id)
        {
            List<CTHoaDonDTO> dscthd = new List<CTHoaDonDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from CT_HoaDon Where id like @id", conn);
            cmd.Parameters.AddWithValue("@id", "%" + id + "%");
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CTHoaDonDTO hd = new CTHoaDonDTO();
                    hd.id = reader.GetInt32(0);
                    hd.traiCay_id = reader.GetInt32(1);
                    hd.gia = reader.GetSqlMoney(2);
                    hd.soLuong = reader.GetInt32(3);
                    hd.giamGia = reader.GetSqlMoney(4);
                    hd.tongGia = reader.GetSqlMoney(5);
                    dscthd.Add(hd);
                }
                reader.Close();
                conn.Close();
            }

            return dscthd;
        }
    }
}
