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
    public class sqlConnecTionData
    {
        public static SqlConnection connect()
        {
            string strcon = "Data Source=localhost;Initial Catalog=quan_trai_cay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DBAccess
    {
        

        public List<HoaDonDTO> loadHoaDonDTO()
        {
            List<HoaDonDTO> hoadon = new List<HoaDonDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from hoaDon", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HoaDonDTO hoa_don = new HoaDonDTO();
                    hoa_don.id = reader.GetInt32(0);
                    hoa_don.khachHang_id = reader.GetInt32(1);
                    hoa_don.nhanVien_id = reader.GetInt32(2);
                    hoa_don.ngayLap = reader.GetDateTime(3);
                    hoa_don.thanhTien = reader.GetSqlMoney(4);
                    hoa_don.chietKhau = reader.GetInt32(5);
                    hoa_don.trangThai = reader.GetInt32(6);
                    hoadon.Add(hoa_don);
                }

            }

            return hoadon;
        }

        public List<CTHoaDonDTO> loadCTHoaDonDTO()
        {
            List<CTHoaDonDTO> cthoadon = new List<CTHoaDonDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from CT_HoaDon", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CTHoaDonDTO cthoa_don = new CTHoaDonDTO();
                    cthoa_don.id = reader.GetInt32(0);
                    cthoa_don.traiCay_id = reader.GetInt32(1);
                    cthoa_don.gia = reader.GetSqlMoney(2);
                    cthoa_don.soLuong = reader.GetInt32(3);
                    cthoa_don.giamGia = reader.GetSqlMoney(4);
                    cthoa_don.tongGia = reader.GetSqlMoney(5);
                    cthoadon.Add(cthoa_don);
                }

            }

            return cthoadon;
        }
        public List<lo_TraiCayDTO> loadlo_TraiCayDTO()
        {
            List<lo_TraiCayDTO> lo_TraiCay = new List<lo_TraiCayDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from lo_TraiCay", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lo_TraiCayDTO lotraicay = new lo_TraiCayDTO();
                    lotraicay.id = reader.GetInt32(0);
                    lotraicay.ngayNhap = reader.GetDateTime(1);
                    lo_TraiCay.Add(lotraicay);
                }

            }

            return lo_TraiCay;
        }
    }
}
