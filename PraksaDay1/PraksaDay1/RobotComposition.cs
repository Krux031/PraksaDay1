using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class RobotComposition //Composition over inheritance
    {
        public String Model;
        public bool Cisti;
        public bool Zabavlja;

        public RobotComposition(String model, bool cisti, bool zabavlja)
        {
            Model = model;
            Cisti = cisti;
            Zabavlja = zabavlja;
        }

        public void MogucnostRobota()
        {
            if (Cisti == true && Zabavlja == true) { Console.WriteLine("cisti i zabavlja"); }
            if (Cisti == true && Zabavlja == false) { Console.WriteLine("cisti"); }
            if (Cisti == false && Zabavlja == true) { Console.WriteLine("zabavlja"); }
        }

    }
}
