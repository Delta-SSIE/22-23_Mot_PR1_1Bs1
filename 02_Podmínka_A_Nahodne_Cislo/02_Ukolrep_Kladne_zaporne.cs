using System;

namespace Ukol_Replit___Kladné__nebo_záporné
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš mi číslo ");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo > 0)
            {
                Console.WriteLine("Číslo je kladné!");
            } else if (cislo == 0)
            {
                Console.WriteLine("Číslo je nula!");
            } else
            {
                Console.WriteLine("Čislo je záporné!");
            }
        }
    }
}
