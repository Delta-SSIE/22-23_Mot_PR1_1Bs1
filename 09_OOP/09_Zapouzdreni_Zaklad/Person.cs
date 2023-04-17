using System;
using System.Collections.Generic;
using System.Text;

namespace Zaklad_Zapouzdreni
{
    internal class Person
    {
        private double vyska; //field

        public double Vyska //properties
        {
            //Ovlivnuji výpis, aby se převedl z cm do m!
            get { return vyska/100; }

            //Ovlivnění zápisu do proměnné, pomocí podmínky!
            set { 
            if (value > 272)
                {
                    vyska = 0;
                } else
                {
                    vyska = value;
                }
            }
        }

    }
}
