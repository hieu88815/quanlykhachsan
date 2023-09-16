using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phongf_DTO
    {
        public string maphong;
        public string tenphong;
        public string loaiphong;
        public Phongf_DTO() { }
        public Phongf_DTO(string maphong, string tenphong, string loaiphong)
        {
            this.loaiphong = loaiphong; 
            this.maphong = maphong;
            this.tenphong = tenphong;
        }
    }
}
