using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class TraiCayBUS
    {
        TraiCay traicays = new TraiCay();
        public List<TraiCayDTO> loadTraiCay()
        {
            return traicays.loadTraiCay();
        }

        public List<TraiCayDTO> timKiemTraiCay(string tenTraiCay)
        {
            return traicays.timKiemTraiCay(tenTraiCay);
        }
        public bool suaTraiCay(TraiCayDTO traicay)
        {
            return traicays.suaTraiCay(traicay);
        }
        public bool suaTraiCay2(TraiCayDTO traicay)
        {
            return traicays.suaTraiCay2(traicay);
        }
        public bool themTraiCay(TraiCayDTO traicay)
        {
            return traicays.themTraiCay(traicay);
        }
        public bool xoaTraiCay(TraiCayDTO traicay)
        {
            return traicays.xoaTraiCay(traicay);
        }
    }
}
