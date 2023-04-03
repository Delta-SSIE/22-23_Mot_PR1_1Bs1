using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Ukolrep_vypisdeti_vypiszeny
{
    enum SexType : byte { Male, Female }

    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public SexType Sex;

        public string IntroduceSelf()
        {
            string predstaveni = $"{Surname}, {Name}, ({Sex}, {Age} years)";
            return predstaveni;
        }
    }
}
