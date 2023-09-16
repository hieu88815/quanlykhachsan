using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class GiaPhong_DAL : Connect
    {
        public GiaPhong_DAL() { }
        public DataTable Load_GiaPhong()
        {
            return Load_DL("select * from giaphong");
        }
        public void Undate_giaphong(GiaPhong_DTO ob)
        {
            string sql = "update giaphong set gia = " + ob.gia + " where loaiphong = '" + ob.loaiphong + "'";
            Excecute(sql);
        }
        public void Insert_giaphong(GiaPhong_DTO ob)
        {
            string sql = "insert into giaphong values('" + ob.loaiphong + "', " + ob.gia + ")";
            Excecute(sql);
        }
        public void Delete_giaphong(string loaiphong)
        {
            string sql = "delete from chucvu where machucvu = '" + loaiphong + "'";
            Excecute(sql);
        }
    }
}
