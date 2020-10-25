using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyon_v1
{
    public class Islem
    {
        public string Olay { get; set; }

        public DateTime Zaman { get; set; }

       

        public Islem()
        {
            Olay = "";
            Zaman = DateTime.Now;

        }
    }
}
