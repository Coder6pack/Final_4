using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        public NhanVienAccess nhanVienAccess = new NhanVienAccess();

        public string checkLogin(NhanVien nhanvien)
        {
            if (nhanvien.taiKhoan == "")
            {
                return "requireAccount";
            }
            if (nhanvien.matKhau == "")
            {
                return "requirePassword";
            }

            string infor = nhanVienAccess.checkLoginDTO(nhanvien);
            return infor;
        }

        public List<NhanVien> dsNhanVien()
        {
            return nhanVienAccess.dsNhanVienDTO();
        }

        public List<NhanVien> timNhanVien(string tenNhanVien)
        {
            return nhanVienAccess.timKiemNhanVien(tenNhanVien);
        }
        public bool themNhanVien(NhanVien nhanvien)
        {
            return nhanVienAccess.themNhanVien(nhanvien);
        }

        public bool suaNhanVien(NhanVien nhanvien)
        {

            return nhanVienAccess.suaNhanVien(nhanvien);
        }

        public bool xoaNhanVien(NhanVien nhanvien)
        {
            return nhanVienAccess.xoaNhanVien(nhanvien);
        }
    }
}
