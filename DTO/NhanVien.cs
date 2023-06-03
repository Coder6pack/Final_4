using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int id { get; set; }
        public string tenNhanVien { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public string quyen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public int trangThai { get; set; }
        public string hinh { get; set; }
    }
}
