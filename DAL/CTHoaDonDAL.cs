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
    }
}
