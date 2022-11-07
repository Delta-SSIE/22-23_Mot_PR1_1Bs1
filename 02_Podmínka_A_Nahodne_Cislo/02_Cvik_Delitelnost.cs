using System;

namespace Delitelnost_dva_tri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo a já ti řeknu, jestli je dělitelné 2 a 3: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("Číslo je dělitelné 2 a 3!");
                } else
                {
                    Console.WriteLine("Číslo je dělitelné 2!");
                }
            } else if (x % 3 == 0)
            {
                Console.WriteLine("Číslo je dělitelné 3!");
            }
            else
            {
                Console.WriteLine("Číslo není dělitelné, ani 2, ani 3!");
            }
        }
    }
}
