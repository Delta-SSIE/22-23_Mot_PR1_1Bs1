using System;

namespace Suda_Licha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suda licha – úkol replit
            Console.WriteLine("Zadej mi číslo a já zjistím, jestli je sudé, nebo liché!");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo == 0)
            {
                Console.WriteLine("Číslo zadané " + cislo + " je nula!");
            } else if (cislo % 2 == 0)
            {
                Console.WriteLine("Číslo zadané " + cislo + " je sudé!");
            } else
            {
                Console.WriteLine("Číslo zadané " + cislo + " je liché!");
            }
             
        }
    }
}
