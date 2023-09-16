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
    public class GiaPhong_DAL
    {
        GiaPhong_DAL giaphong = new GiaPhong_DAL();
        public DataTable Load_GiaPhong()
        {
            return giaphong.Load_GiaPhong();
        }
        public void Insert_Giaphong(GiaPhong_DAL ob)
        {
            giaphong.Insert_Giaphong(ob);
        }
        public void Update_Giaphong(GiaPhong_DAL ob)
        {
            giaphong.Update_Giaphong(ob);
        }
        public void Delete_GiaPhong(string loaiphong)
        {
            giaphong.Delete_GiaPhong(loaiphong);
        }

    }
}
