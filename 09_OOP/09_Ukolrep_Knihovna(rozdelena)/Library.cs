using System;
using System.Collections.Generic;
using System.Text;

namespace Ukolrep_knihovna
{
    internal class Library
    {
        public string Name;
        public string Location;
        public Book[] Books = new Book[1000];
        public int PocetKnih = 0;

        public Library(string name, string lokace)
        {
            Name = name;
            Location = lokace;
        }

        public void AddBook(string nazev, int rok, string name, int year)
        {
            Book kniha1 = new Book(nazev, rok, name, year);
            Books[PocetKnih] = kniha1;
            PocetKnih++;
            Console.WriteLine($"Přidal jste novou knihu {kniha1.Nazev}");

        }
    }
}
