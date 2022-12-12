using System;
using System.Linq;

namespace Nadprumerne_hodnoty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetcisel = 0;
            int cislo = 0;
            //Uživatel zadá jak velké pole bude
            Console.Write("Zadej kolik chceš vložit celkově čísel ");
            while (!int.TryParse(Console.ReadLine(), out pocetcisel))
            {
                Console.WriteLine("Zadej číslo!");
            }

            //Deklarace pole samotného. Jelikož je pole prázdné, musíme vložit jeho délku.
            int[] cisla = new int[pocetcisel];


            Console.WriteLine($"Nyní budeš zadávat {pocetcisel} čísel");
            //Cyklus na naplnění pole samotného!
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.Write("Zadej číslo ");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo!");
                }
                //Naplnění pozice zadaným číslem!
                cisla[i] = cislo;
            }

            //Vypočítáme si průměrnou hodnotu, kterou vložíme do porměnné.
            int prumer = cisla.Sum() / cisla.Length;

            Console.WriteLine("Ze zadaných čísel jsou nadprůměrná tato:");
            //Průchod polem pomocí foreach 
            foreach (int a in cisla)
            {
                //Podmínka, kdy se řeší, jestli právě načtená hodnota je vyšší než průměr
                if (a > prumer)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }
}
