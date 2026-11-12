using System;
using System.Collections.Generic;
using System.Text;

namespace Katalog_okazow
{
    public class Okaz
    {
        public string Nazwa { get; set; }
        public int WymiarDlugosc { get; set; }
        public int WymiarSzerokosc { get; set; }
        public double Cena { get; set; }
        public string Era { get; set; }
        public string Pochodzenie { get; set; }
        public bool Dostepnosc { get; set; }
        public Okaz(string nazwa, int wymiarDlugosc, int wymiarSzerokosc, double cena, string era, string pochodzenie ,bool dostepnosc)
        {
            Nazwa = nazwa;
            WymiarDlugosc = wymiarDlugosc;
            WymiarSzerokosc = wymiarSzerokosc;
            Cena = cena;
            Era = era;
            Pochodzenie = pochodzenie;
            Dostepnosc = dostepnosc;
        }
    }
}
