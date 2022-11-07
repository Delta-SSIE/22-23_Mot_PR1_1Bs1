using System;

namespace While_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            int max = 0;
            do
            {
                Console.Write("Zadej číslo (ukončení 0, či menší) ");
                cislo = int.Parse(Console.ReadLine());
                max = Math.Max(max, cislo);
            } while (cislo > 0);
            if (max == 0)
            {
                Console.Write("Nezadal si žádné číslo!");
            } else
            {
                Console.WriteLine($"Největší číslo ze zadaných je {max}");
            }
            
        }
    }
}
