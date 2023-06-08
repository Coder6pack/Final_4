using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class quanLyLoaiTraiCayBUS
    {
        public quanLyLoaiTraiCayDAL loaitraicay = new quanLyLoaiTraiCayDAL();
        public List<quanLyLoaiTraiCay> loadquanLyLoaiTraiCay()
        {
            return loaitraicay.loadquanLyTraiCay();
        }
        public bool ThemloaiTraiCay(quanLyLoaiTraiCay quanLyLoaiTraiCayss)
        {
            return loaitraicay.ThemloaiTraiCay(quanLyLoaiTraiCayss);
        }
        public bool XoaloaiTraiCay(int matraicay)
        {
            return loaitraicay.XoaloaiTraiCay(matraicay);
        }
        public bool CapNhatloaiTraiCay(quanLyLoaiTraiCay quanLyLoaiTraiCayss)
        {
            return loaitraicay.CapNhatloaiTraiCay(quanLyLoaiTraiCayss);
        }
        public List<quanLyLoaiTraiCay> TimkiemloaiTraiCay(int idloaicay)
        {
            return loaitraicay.TimkiemloaiTraiCay(idloaicay);
        }
    }
}
