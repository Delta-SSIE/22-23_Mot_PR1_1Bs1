using System;

namespace metoda_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Volání metody
            Pozdrav();
            Pozdrav(); 
            Pozdrav();

            //Volání metody s argumentem
            Pozdrav2("Honza");
            Pozdrav2("Jan");
            Pozdrav2("Libor");

            //Volání metody bez argumentu (využití defualtního parametru)
            Pozdrav2();

            //Volání metody s návratovou hodnotou
            Console.WriteLine(Soucet(5, 5));
            Console.WriteLine(Soucet(20, 50));


        }

        //jednoduchá metoda
        static void Pozdrav()
        {
            Console.WriteLine("Hello world!");
        }

        //metoda s parametrem (defaultní parametr "Jindřich")
        static void Pozdrav2(string jmeno = "Jindřich")
        {
            Console.WriteLine($"Hello {jmeno}");
        }

        //metoda s návratovou hodnotou
        static int Soucet(int x, int y)
        {
            return x + y;
        }
    }
}