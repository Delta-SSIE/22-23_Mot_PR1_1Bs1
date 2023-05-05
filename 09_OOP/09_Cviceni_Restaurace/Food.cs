using System;
using System.Collections.Generic;
using System.Text;

namespace cvic_res
{
    internal class Food
    {
        //Fields třídy Food
        public string name;
        public int price;
        public string type;

        //Konstruktor třídy Food
        public Food(string jmeno, int cena, string typ)
        {
            name = jmeno;
            price = cena;
            type = typ;
        }

    }
}
