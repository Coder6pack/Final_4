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
    }
}
