using System;

namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            //Modulus
            Console.WriteLine(x % y);

            //Inkriminace a dekremntace
            x++;
            x--;
            Console.WriteLine(x);

            //Přiřazovací operátor
            x += 3;
            x *= 3;
            Console.WriteLine(x);

            //Porovnávací operátor
            Console.WriteLine(x > y);
        }
    }
}
