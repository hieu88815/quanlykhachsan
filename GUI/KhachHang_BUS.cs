using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class KhachHang_BUS
    {
        KhachHang_DAL khachhang = new KhachHang_DAL();
        public DataTable Load_KhachHang()   
        {
            return khachhang.Load_KhachHang();
        }
        public void Insert_KhachHang(KhachHang_DAL ob)
        {
            khachhang.Insert_KhachHang(ob);
        }
        public void Update_KhachHang(KhachHang_DAL ob)
        {
            khachhang.Update_khachHang(ob);
        }
        public void Delete_khachhang(string ID)
        {
            khachhang.Delete_KhachHang(ID);
        }
    }
}
