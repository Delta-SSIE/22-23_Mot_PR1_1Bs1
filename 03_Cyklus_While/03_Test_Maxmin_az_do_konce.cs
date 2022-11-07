using System;

namespace Minimax_až_do_konce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            string vstup;
            int max = 0;
            int min = 99999;
            int pocetcisel = 0;
            int soucet = 0;
            do
            {
                //Tady tenhle do-while řeší celý TryParse... Tady bacha, protože musí projít i to "X" pro ukončení
                do
                {
                    Console.Write("Zadej číslo ");
                    vstup = Console.ReadLine();
                } while (!int.TryParse(vstup, out cislo) && vstup != "X"); // Musí se ošetřit "X". Stačí aby jedno tvrzení neplatilo a celý cyklus se zastaví
              
                if (vstup != "X") //Zajištuje, že poslední průchod s "X" se nebude počítat
                {
                    max = Math.Max(max, cislo);
                    min = Math.Min(min, cislo);
                    pocetcisel++;
                    soucet += cislo;
                }
            } while (vstup != "X");

            Console.WriteLine($"Nejvyšší číslo je {max}\nNejmenší číslo je {min}\nPrůměr čísel je {soucet/pocetcisel}");
        }
    }
}
