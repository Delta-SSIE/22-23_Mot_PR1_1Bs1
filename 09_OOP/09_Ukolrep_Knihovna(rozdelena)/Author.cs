using System;
using System.Collections.Generic;
using System.Text;

namespace Ukolrep_knihovna
{
    internal class Author
    {
        public string Jmeno;
        public int BirthYear;

        public Author (string jmeno, int rok)
        {
            Jmeno = jmeno;
            BirthYear = rok;
        }
    }
}
