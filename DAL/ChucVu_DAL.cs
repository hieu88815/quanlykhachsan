﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVu_DAL : Connect
    {
        public ChucVu_DAL() { }
        public DataTable Load_ChucVu()
        {
            return Load_DL("select * from chucvu");
        }
        public void Undate_chucvu(ChucVu_DTO ob) { 
            string sql = "update chucvu set tenchucvu = '" + ob.tenchucvu + "', tenchucvu = N'" + ob.tenchucvu + " where machucvu" + ob.machucvu + "'";
            Excecute(sql);
        }
        public void Insert_chucvu(ChucVu_DTO ob)
        {
            string sql = "insert into chucvu values ('" + ob.machucvu + "', '" + ob.tenchucvu + "', " + ob.machucvu + "')";
            Excecute(sql);
        }
        public void Delete_chucvu(string machucvu)
        {
            string sql = "delete from chucvu where machucvu = '" + machucvu + "'";
            Excecute(sql);
        }

        public void Insert_chucvu(ChucVu_DAL ob)
        {
            throw new NotImplementedException();
        }

        public void Undate_chucvu(ChucVu_DAL ob)
        {
            throw new NotImplementedException();
        }
    }
}
