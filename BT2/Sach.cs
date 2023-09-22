using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Sach
    {
        public int masach {  get; set; }
        public String  tensach { get; set; }
        public String tacgia {  get; set; }
        public Sach() { 
           
        }
        public Sach(int ms, string ts, string tg)
        {
            masach = ms;
            tensach = ts;
            tacgia = tg;
        }
    }
}
