using Katalog_okazow;

class Program
{



    static void Main(string[] args)
    {
        bool menu = true;
        Magazyn magazyn = new Magazyn();
        Console.WriteLine("Witaj w programie do obsługi sklepu paleontologicznego.");
        while (menu)
        {
            Console.WriteLine();
            Console.WriteLine("1. Dodaj okaz");
            Console.WriteLine("2. Usuń okaz");
            Console.WriteLine("3. Wyświetl okazy");
            Console.WriteLine("4. Zapisz stan");
            Console.WriteLine("5. Wczytaj stan");
            Console.WriteLine("6. Wyjdź z programu");
            int wybor1 = int.Parse(Console.ReadLine());
            switch (wybor1)
            {
                case 1:
                    magazyn.DodajOkaz();
                    Console.WriteLine("Okaz został dodany. ");
                    break;
                case 2:
                    magazyn.UsunOkaz();
                    Console.WriteLine("Usunięto okaz.");
                    break;
                case 3:
                    magazyn.WyswietlOkaz();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    menu = false;
                    break;
            }


        }
    }
}