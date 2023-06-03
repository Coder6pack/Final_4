using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CTHoaDonDAL:DBAccess
    {
        public List<CTHoaDonDTO> loadCTHoaDon()
        {
            List<CTHoaDonDTO> dsCTHOADON = loadCTHoaDonDTO();
            return dsCTHOADON;
        }
    }
}
