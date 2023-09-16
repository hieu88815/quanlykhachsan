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
    public class ChucVu_BUS
    {
        ChucVu_DAL chucvu = new ChucVu_DAL();
        public DataTable Load_Chucvu()
        {
            return chucvu.Load_ChucVu();
        }

        public void Insert_Chucvu(ChucVu_DAL ob)
        {
            chucvu.Insert_chucvu(ob);
        }
        public void Update_Chucvu(ChucVu_DAL ob)
        {
            chucvu.Undate_chucvu(ob);
        }
        public void Delete_Chucvu(string machucvu)
        {
            chucvu.Delete_chucvu(machucvu);
        }
    }
}
