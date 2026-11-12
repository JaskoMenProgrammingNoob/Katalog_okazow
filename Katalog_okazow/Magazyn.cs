using System;
using System.Collections.Generic;
using System.Text;

namespace Katalog_okazow
{
    public class Magazyn
    {
        public List<Okaz> Okazy { get; set; } = [];

        public  Okaz DodajOkaz()
        {
            Console.WriteLine("Podaj nazwę: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj długość : ");
            int wymiarDlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość: ");
            int wymiarSzerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cenę: ");
            double cena = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź erę okazu: ");
            string era = Console.ReadLine();
            Console.WriteLine("Wprowadz pochodzenie okazu: ");
            string pochodzenie = Console.ReadLine();
            bool dostepnosc = true;
            Console.WriteLine("Czy okaz jest na stanie magazynowym? tak/nie");
             string decyzja = Console.ReadLine();
             if(decyzja == "tak")
             {
                 dostepnosc = true;
             } else if (decyzja == "nie")
            {
                dostepnosc = false;
            }
            Okaz okaz = new Okaz(nazwa, wymiarDlugosc, wymiarSzerokosc, cena, era, pochodzenie, dostepnosc);
            //
            Okazy.Add(okaz);
           
           
            
            return okaz;
            
            
            
            
            
            
            
            
           

        }
    }
}
