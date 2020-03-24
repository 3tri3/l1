using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        public class ustroistvo
        {
            public string proizvod { get; set; }
            public string model { get; set; }
            public int god_nachala_proizvod { get; set; }
            public string standart_svazy { get; set; }
        }

        class mobilnyi : ustroistvo
        {
            public void naim(string proizvod, string model)
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
