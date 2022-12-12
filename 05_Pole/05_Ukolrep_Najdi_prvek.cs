using System;

namespace Najdi_prvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
            int cislo = 0;
            int kontrola = 0;

            while(true)
            {
                kontrola = 0;
                Console.WriteLine("Zadej číslo!");
                while(!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo! Vámi zadaný vstup není číslo!");
                }

                for (int i = 0; i < cisla.Length; i++)
                {
                    if (cisla[i] == cislo)
                    {
                        Console.WriteLine($"Čislo {cislo} se v poli nachází na {i}. indexu");
                        kontrola = 1;
                        break;
                    }

                }
                if (kontrola == 0)
                {
                    Console.WriteLine($"Číslo {cislo} v poli není!");
                }
            }
        }
    }
}
