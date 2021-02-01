using System;
using System.Collections.Generic;

namespace PraksaDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Kruno", "Semialjac", 1996, 1.89, true);
            osoba.Ispis();
            Zaposlenik zap = new Zaposlenik("Ivo", "Ivic", 1994, 1.89, true, 1, "developer");
            zap.Ispis();
            
            Brod brod = new Brod("plovidbeno"); //primjer interface
            brod.VrstaIspis();

            Pas pas = new Pas("Ben"); //primjer abstract
            Pas dog = new Pas("Bobi");
            pas.Glasanje();

            List<int> lista = new List<int>(); //generics
            lista.Add(5);
            lista.Add(7);

            List<Pas> psi = new List<Pas>(); //generics
            psi.Add(pas);
            psi.Add(dog);
        }
    }
}
