using System;
using System.Diagnostics.SymbolStore;

namespace Tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstup = Console.ReadLine();
            int cislo;
            Console.WriteLine(int.TryParse(vstup, out cislo));


            string a;
            do
            {
                Console.WriteLine("Zadej číslo: ");
                a = Console.ReadLine();
            } while (!int.TryParse(a, out cislo));

        }
    }
}
