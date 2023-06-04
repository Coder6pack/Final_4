using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class GioHangTraiCay
    {
        public List<TraiCayDTO> loadGioHang()
        {
            List<TraiCayDTO> dsGioHang = new List<TraiCayDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from quanLyTraiCay", conn);
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
    }
}
