using System;

namespace Absolut_hodnota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ahoj, zadej mi číslo a já ti vypíšu jeho absolutní hodnotu: ");
            float cislo = float.Parse(Console.ReadLine());

            if (cislo < 0)
            {
                cislo *= -1;
            }

            Console.WriteLine($"Absolutní hodnota zadaného čísla je {cislo}");
        }
    }
}
