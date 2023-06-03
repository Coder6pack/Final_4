using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class GioHangTraiCayBUS
    {
        GioHangTraiCay gioHang = new GioHangTraiCay();

        public List<TraiCayDTO> loadGioHang()
        {
            return gioHang.loadGioHang();
        }
    }
}
