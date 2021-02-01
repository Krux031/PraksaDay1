using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class Pas : Zivotinja
    {
        public String Ime;

        public Pas(String ime)
        {
            Ime = ime;
        }
        public override void Glasanje()
        {
            Console.WriteLine("vau-vau");
        }
    }
}
