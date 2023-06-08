using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {
        public HoaDonDAL hoadons = new HoaDonDAL();
        public List<HoaDonDTO> loadDSHoaDon()
        {
            return hoadons.loadDSHoaDon();
        }
        public bool ThemHoaDon(HoaDonDTO HoaDonDTOs)
        {
            return hoadons.themHoaDon(HoaDonDTOs);
        }
        public bool xoaHoaDon(HoaDonDTO hoadon)
        {
            return hoadons.xoaHoaDon(hoadon);
        }

        public bool capNhatHoaDon(HoaDonDTO hoaDon)
        {
            return hoadons.capNhatHoaDon(hoaDon);
        }
        public List<HoaDonDTO> timKiemHoaDon(string tenHoaDon)
        {
            return hoadons.timKiemHoaDon(tenHoaDon);
        }
    }
}
