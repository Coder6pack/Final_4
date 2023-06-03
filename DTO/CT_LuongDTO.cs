using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_LuongDTO
    {
        public int id { get; set; }
        public int nhanVien_id { get; set; }
        public SqlMoney luong { get; set; }
        public int gioDangNhap { get; set; }
        public string thang_Nam { get; set; }
        public SqlMoney tongLuong { get; set; }
    }
}
