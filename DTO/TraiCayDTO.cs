using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraiCayDTO
    {
        public int id { get; set; }
        public int loaiTraiCay_id { get; set; }
        public int loTraiCay_id { get; set; }
        public string tenTraiCay { get; set; }
        public SqlMoney gia { get; set; }
        public int soLuong { get; set; }
        public DateTime HSD { get; set; }
        public int trangThai { get; set; }
        public string hinh { get; set; }
    }
}
