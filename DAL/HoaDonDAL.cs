using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonDAL:DBAccess
    {
        public List<HoaDonDTO> loadDSHoaDon()
        {
            List<HoaDonDTO> dsHoaDon = loadHoaDonDTO();
            return dsHoaDon;
        }
    }
}
