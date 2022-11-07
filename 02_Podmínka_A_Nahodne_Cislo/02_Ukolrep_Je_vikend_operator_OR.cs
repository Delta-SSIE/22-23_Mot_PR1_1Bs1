using System;

namespace Je_vikend_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrý den, řekněte jaký den je? (povolený vstup: 1–7)");
            int den = int.Parse(Console.ReadLine());

            /* Řešení, co neřeší nesmyslné číslo
            if ( den > 5)
            {
                Console.WriteLine("Je víkend!");
            } else
            {
                Console.WriteLine("Stále je týden");
            }
            */

            //Řešení s AND
            //if (den > 5 && den < 8)
            //{
            //    Console.WriteLine("Je víkend!");
            //}
            //else if (den > 0 && den < 6)
            //{
            //    Console.WriteLine("Stále je týden");
            //} else
            //{
            //    Console.WriteLine("Zadané nesmyslné číslo");
            //}

            //Řešení s OR
            if (den == 6 || den == 7)
            {
                Console.WriteLine("je víkend!");
            }
            else if (den == 1 || den == 2 || den == 3 || den == 4 || den == 5)
            {
                Console.WriteLine("stále je týden");
            }
            else
            {
                Console.WriteLine("zadané nesmyslné číslo");
            }
        }
    }
}
