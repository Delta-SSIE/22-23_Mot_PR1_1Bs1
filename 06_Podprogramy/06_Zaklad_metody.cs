using System;

namespace metody_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Volání metody s argumenty
            Mojemetoda("Honzo!");
            Mojemetoda("Vaáclave!");
            Mojemetoda("Vítku!");
            Mojemetoda("Filipe!");

            //Volání metody s dvěma argumenty
            Scitani(5, 5);
            Scitani(10, 15);

            //Volání metody s předepsaným parametrem
            Zeme("Irsko");
            Zeme();

            //Volání metody s návratovou hodnotou
            Console.WriteLine(Nasobeni(5, 5));
            int x = Nasobeni(20, 40);
            Console.WriteLine(x);

            //Volání metody bez parametru s návratovou hodnotou
            int y = Parsuj();
            Console.WriteLine(y);

        }

        //Moje nová metoda (podprogram) s parametrem textovým (jmeno)
        static void Mojemetoda(string jmeno)
        {
            Console.WriteLine($"Ahoj {jmeno}!");
        }

        //Metoda s dvěma parametry
        static void Scitani(int x, int y)
        {
            Console.WriteLine($"Součet hodnot je {x+y}");
        }

        //Metoda s předepsaným parametrem
        static void Zeme(string zem = "Česko")
        {
            Console.WriteLine("Jsem z " + zem);
        }

        //Metoda s return (návratovou hodnotou)
        static int Nasobeni (int x, int y)
        {
            return x * y;
        }

        //Metoda bez parametru, co vrací číslo!
        static int Parsuj ()
        {
            string a;
            int cislo;
            do
            {
                Console.WriteLine("Zadej číslo: ");
                a = Console.ReadLine();
            } while (!int.TryParse(a, out cislo));
            return cislo;
        }
    }
}
