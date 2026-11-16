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
                Console.WriteLine(dostepnosc ? "tak" : "nie");
             } else if (decyzja == "nie")
            {
                dostepnosc = false;
            }
            Okaz okaz = new Okaz(nazwa, wymiarDlugosc, wymiarSzerokosc, cena, era, pochodzenie, dostepnosc);
            
            Okazy.Add(okaz);
           
           
            
            return okaz;
            
        }
            
            
            public List<Okaz> WyswietlOkaz()
        {
            Console.WriteLine("=====LISTA OKAZÓW======");
            for(int i = 0; i < Okazy.Count; i++)
            {
                
                Console.WriteLine($"Okaz nr. {i + 1}");
                Console.WriteLine($"Nazwa: {Okazy[i].Nazwa}");
                Console.WriteLine($"Długość: {Okazy[i].WymiarDlugosc}");
                Console.WriteLine($"Szerokość: {Okazy[i].WymiarSzerokosc}");
                Console.WriteLine($"Cena: {Okazy[i].Cena}");
                Console.WriteLine($"Era: {Okazy[i].Era}");
                Console.WriteLine($"Pochdzenie: {Okazy[i].Pochodzenie}");
                Console.WriteLine($"W magazynie: {Okazy[i].Dostepnosc}");
                Console.WriteLine();

            }
            return Okazy;
        }
            
            public List<Okaz> UsunOkaz()
        {
            Console.WriteLine("Wybierz z listy okaz, który chcesz usunąć (wprowadź odpowiedni numer): ");
            int i = Wejscie.WczytajLiczbe("Podaj numer okazu do usunięcia: ", 1, Okazy.Count);
            Okaz wybor = Okazy[i - 1];
            
            Okazy.RemoveAt(i - 1);

            return Okazy;
        }


        //Klasa pomocnicza
        public static class Wejscie
        { 
            public static int WczytajLiczbe(string pytanie, int min, int max)
            {
                while (true)
                {
                    Console.Write(pytanie);
                    string tekst = Console.ReadLine() ?? "";
                    if (int.TryParse(tekst, out int Liczba) && Liczba >= min && Liczba <= max)
                        return Liczba;

                    Console.WriteLine($"Podaj liczbę od {min} do {max}.");
                }
            }
        }


    }
}
