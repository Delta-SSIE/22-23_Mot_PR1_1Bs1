using System;
using System.Text.Json;

namespace Počty_podle_velikosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            int jednacifra = 0;
            int dvecifry = 0;
            int trojcifer = 0;
            int vetsi = 0;
            string vstup;

            do
            {
                //Tady tenhle do-while řeší celý TryParse... je to zkrátka cyklus v cyklu, který má za úkol pustit jen číslo.
                do
                {
                    Console.Write("Zadej číslo ");
                    vstup = Console.ReadLine();
                } while (!int.TryParse(vstup, out cislo));

                if (cislo >= 1000)
                {
                    vetsi++;
                }
                else if (cislo >= 100)
                {
                    trojcifer++;
                }
                else if (cislo >= 10)
                {
                    dvecifry++;
                }
                else if (cislo > 0) //Tohle je nutné, aby se nám nazpočítala nula, či záporné číslo.
                {
                    jednacifra++;
                }
            } while (cislo > 0);

            Console.WriteLine($"Zapsal jste {jednacifra} jednociferných, {dvecifry} dvojciferných, {trojcifer} trojciferných a {vetsi} větších čísel.");

        }
    }
}
