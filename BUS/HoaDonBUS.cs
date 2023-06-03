using System;
using System.Collections.Generic;
using System.Linq;
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
        //public bool ThemHoaDon(HoaDonDTO HoaDonDTOs)
        //{
        //    return hoadons.ThemHoaDon(HoaDonDTOs);
        //}
        //public bool ThemCTHoaDon(CTHoaDonDTO cthoadondto)
        //{
        //    return hoadons.ThemCTHoaDon(cthoadondto);
        //}
    }
}
