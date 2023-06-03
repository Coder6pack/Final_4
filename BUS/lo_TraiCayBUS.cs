using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class lo_TraiCayBUS
    {
        public lo_TraiCayDAL lotraicays = new lo_TraiCayDAL();
        public List<lo_TraiCayDTO> loadlo_TraiCay()
        {
            return lotraicays.loadlo_TraiCay();
        }
        public bool Themlo_TraiCay(lo_TraiCayDTO lo_TraiCayDTOs)
        {
            return lotraicays.Themlo_TraiCay(lo_TraiCayDTOs);
        }
        public bool Xoalo_TraiCay(int malohangg)
        {
            return lotraicays.Xoalo_TraiCay(malohangg);
        }
        public bool CapNhatlo_TraiCay(lo_TraiCayDTO lo_TraiCayDTOs)
        {
            return lotraicays.CapNhatlo_TraiCay(lo_TraiCayDTOs);
        }
        public List<lo_TraiCayDTO> TimkiemloTraiCay(int Malohang )
        {
            return lotraicays.TimkiemloTraiCay(Malohang);
        }    
    }
}
