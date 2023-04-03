using System;
using System.Collections.Generic;
using System.Text;

namespace Ukolrep_knihovna
{
    internal class Book
    {
        public string Nazev;
        public int YearPublished;
        public Author Author;

        public Book(string nazev, int rok, string jmenoautora, int roknarozeniautora)
        {
            Nazev = nazev;
            YearPublished = rok;
            Author = new Author(jmenoautora, roknarozeniautora);
        }
    }

    
}
