using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHang khachhang = new KhachHang();

        public string checkKhachHang(KhachHangDTO khachHang)
        {
            if(khachHang.sdt == "")
            {
                return "requireCustomer";
            }
            if(khachHang.tenKhachHang == "")
            {
                return "requireNameCustomer";
            }
            return khachhang.checkKhachHang(khachHang);
        }

        public bool themKhachHang(KhachHangDTO khachHang)
        {
            return khachhang.themKhachHang(khachHang);
        }
    }
}
