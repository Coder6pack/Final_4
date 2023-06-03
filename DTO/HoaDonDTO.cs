using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DTO
{
    public class HoaDonDTO
    {
        public int id { get; set; }
        public int khachHang_id { get; set; }
        public int nhanVien_id { get; set; }
        public DateTime ngayLap { get; set; }
        public SqlMoney thanhTien { get; set; }
        public int chietKhau { get; set; }
        public int trangThai { get; set; }
    }
}
