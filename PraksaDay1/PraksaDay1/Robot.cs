using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class Robot
    {
        public String Model; 

        public Robot (String model)
        {
            Model = model;
        }

    }
    class Cistac: Robot 
    {
        public Cistac(String model) : base(model) { }

        public void Cisti() { Console.WriteLine("cisti"); }
    }
    class Zabavljac: Robot
    {
        public Zabavljac(String model) : base(model) { Console.WriteLine("zabavlja"); }

        public void Zabavlja() { }
    }

    class CistacZabavljac: Robot
    {
        public CistacZabavljac(String model) : base(model) { }

        public void CistiZabavlja() { Console.WriteLine("cisti i zabavlja"); }
    }
}
