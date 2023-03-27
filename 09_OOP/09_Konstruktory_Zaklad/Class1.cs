using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktory_Zaklad
{
    internal class Animal
    {
        //Fields
        public int Nohy;
        public string Jmeno;

        //Konstruktor classy Animal
        public Animal(int legs, string name)
        {
            Nohy = legs;
            Jmeno = name;
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Ahoj, já jsem {Jmeno} a mám {Nohy} nohy!");
        }
    }

    
}
