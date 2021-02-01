using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class Osoba 
    {
        public String Ime;
        public String Prezime;
        public int Godina_rodjenja;
        public double Visina;
        protected bool Nesto;
        public Osoba() { }
        public Osoba(String ime, String prezime, int godina, double visina, bool nesto)
        {
            Ime = ime; 
            Prezime = prezime;
            Godina_rodjenja = godina; 
            Visina = visina;
            Nesto = nesto;
        }

        public virtual void Ispis()
        {
            Console.WriteLine("Osoba: " + Ime + " " + Prezime + ", " + Godina_rodjenja);
        }

    }

}
