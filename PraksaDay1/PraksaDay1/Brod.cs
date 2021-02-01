using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class Brod : IVozilo
    {
        public String Vrsta;
        public Brod(String vrsta) 
        {
            Vrsta = vrsta;
        }
        public void VrstaIspis()
        {
            Console.WriteLine(Vrsta);
        }
    }


}
