using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DTO
{
    public class CTHoaDonDTO
    {
        public int id { get; set; }
        public int traiCay_id { get; set; }
        public SqlMoney gia { get; set; }
        public int soLuong { get; set; }
        public SqlMoney giamGia { get; set; }
        public SqlMoney tongGia { get; set; }
    }
}
