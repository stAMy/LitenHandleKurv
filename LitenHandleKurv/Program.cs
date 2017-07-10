using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitenHandleKurv
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare("kesam", 1, 20);
            Vare v1 = new Vare("melk", 2, 27);
            Vare v2 = new Vare("Agurk", 3, 30);

            Varelager vl = new Varelager();

            vl.leggTil(v);
            vl.leggTil(v1);
            vl.leggTil(v2);

            vl.visAlleVarer();
            vl.slettVare(2);
            vl.visAlleVarer();
            Console.WriteLine("Totalsum å betale: " + vl.totalSum());
            Console.ReadLine();

        }
    }
}
