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
                int volba = 0;
                Console.Clear();
                Console.WriteLine($"Vítej v knihovně {knihovna.Name} v lokace {knihovna.Location}");
                Console.WriteLine("Pro přidání knihy napiš 1\nPro nalezení knih dle autora napiš 2");
                try
                {
                    volba = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zadali jste špatně!");
                    Console.ReadKey();
                }
                if (volba == 1)
                {
                    Console.Write("Napiš název knihy: ");
                    string nazev = Console.ReadLine();
                    Console.Write("Napiš rok vydání knihy: ");
                    int rokkniha = int.Parse(Console.ReadLine());
                    Console.Write("Napiš přijmení autora: ");
                    string autor = Console.ReadLine();
                    Console.Write("Napiš rok narození autora: ");
                    int rokautor = int.Parse(Console.ReadLine());
                    knihovna.AddBook(nazev, rokkniha, autor, rokautor);
                }
                else if (volba == 2)
                {
                    Console.Write("Napiš název autora: ");
                    string nazev = Console.ReadLine();
                    knihovna.FindBookByAuthor(nazev);
                }
                Console.ReadKey();
            }
        }
    }
}
