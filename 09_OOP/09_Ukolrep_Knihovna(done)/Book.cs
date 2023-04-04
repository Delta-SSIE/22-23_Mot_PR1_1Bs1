using System;
using System.Collections.Generic;
using System.Text;

namespace Ukolrep_knihovna
{
    internal class Book
    {
        public string Nazev;
        public int YearPublished;
        public string Author;
    


        public Book(string nazev, int rok, string name)
        {
            Nazev = nazev;
            YearPublished = rok;
            Author = name;
        }
    }

    
}
