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
    }
}
