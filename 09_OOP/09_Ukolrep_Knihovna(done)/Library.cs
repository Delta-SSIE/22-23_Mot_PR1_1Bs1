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
        Author[] Authors = new Author[]
    {
            new Author("Salinger",1919)
};
        public int PocetAutoru = 0;

        public Library(string name, string lokace)
        {
            Name = name;
            Location = lokace;
        }

        public void AddBook(string nazev, int rok, string name, int year)
        {
            Book kniha1 = new Book(nazev, rok, name);
            int check = 0;
            foreach (Author x in Authors)
            {
                if (x.Jmeno == name && x.BirthYear == year)
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                Author autor = new Author(name, year);
                Authors[PocetAutoru] = autor;
                PocetAutoru++;
                Console.WriteLine($"Přidán nový autor do databáze {autor.Jmeno}");
            }

            Books[PocetKnih] = kniha1;
            PocetKnih++;
            Console.WriteLine($"Přidal jste novou knihu {kniha1.Nazev}");

        }
        public void FindBookByAuthor(string jmeno)
        {
            foreach (Book x in Books)
            {
                if(x.Author == jmeno)
                {
                    Console.WriteLine($"{x.Nazev} vydaný {x.YearPublished}, napsal {x.Author}");
                }
            }
        }
    }
}
