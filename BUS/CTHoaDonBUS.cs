using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class CTHoaDonBUS
    {
        public CTHoaDonDAL cthoadon = new CTHoaDonDAL();
        public List<CTHoaDonDTO> loadCTHoaDon()
        {
            return cthoadon.loadCTHoaDon();
        }
        public bool themCTHoaDon(CTHoaDonDTO cthd)
        {
            return cthoadon.themCTHoaDon(cthd);
        }
        public bool xoaCTHoaDon(CTHoaDonDTO cthd)
        {
            return cthoadon.xoaCTHoaDon(cthd) ;
        }

        public List<CTHoaDonDTO> timKiemCTHoaDon(string cthd)
        {
            return cthoadon.timKiemCTHoaDon(cthd);
        }
    }
}
