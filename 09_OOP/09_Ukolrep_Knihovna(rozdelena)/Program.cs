using System;

namespace Ukolrep_knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj! Zadej jméno své knihovny!");
            string knihovnanazev = Console.ReadLine();
            Console.WriteLine($"Kde se tvá knihovna {knihovnanazev} nachází?");
            string knihovnalokace = Console.ReadLine();

            Library knihovna = new Library(knihovnanazev, knihovnalokace);

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Vítej v knihovně {knihovna.Name} v lokace {knihovna.Location}");
                
                knihovna.AddBook("Kdo chyta v žitě", 1951, "J. D. Salinger", 1919);
                Console.ReadKey();
            }
        }
    }
}
