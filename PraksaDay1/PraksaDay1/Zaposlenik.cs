using System;
using System.Collections.Generic;
using System.Text;

namespace PraksaDay1
{
    class Zaposlenik : Osoba //inheritance
    {
        private int ID;
        public String Pozicija;

        public Zaposlenik() : base() { }
        public Zaposlenik(String ime, String prezime, int godina, double visina, bool nesto, int id, String pozicija) : base(ime, prezime, godina, visina, nesto)
        {
            ID = id;
            Pozicija = pozicija;
        }

        public override void Ispis() //polymorphism
        {
            Console.WriteLine(Prezime + " " + Ime + ": " + Pozicija + Nesto);
        }
    }
}
