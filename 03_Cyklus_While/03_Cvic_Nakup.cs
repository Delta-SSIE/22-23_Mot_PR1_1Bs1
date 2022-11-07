using System;

namespace Nakup_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v programu Nákupní seznam!");
            int pocetpol = 0;
            double cena = 0;
            string zbozi;

            do
            {
                Console.WriteLine("Chceš koupit rohlík, housku, či chleba? (zádávej r/h/ch)");
                zbozi = Console.ReadLine();
                if (zbozi == "r")
                {
                    // cena = cena + 3.5;
                    cena += 3.5;
                    pocetpol++;
                }
                if (zbozi == "h")
                {
                    cena += 5.5;
                    pocetpol++;
                }
                if (zbozi == "ch")
                {
                    cena += 10;
                    pocetpol++;
                }
            } while (zbozi != "0" && pocetpol < 10);

            Console.WriteLine($"Počet položek na seznamu je {pocetpol} a celková cena je {cena}");
        }
    }
}
