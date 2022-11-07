using System;

namespace Nahod_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Založení generátoru (v kódu je právě jednou!)
            Random Genrand = new Random();

            //Jak generovat? – Genrand.Next(dolní mez, horní mez-1)
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));
            Console.WriteLine(Genrand.Next(1, 11));

            //Specialita – Genrand.NextDouble()
            Console.WriteLine(Genrand.NextDouble());
            Console.WriteLine(Genrand.NextDouble());
            Console.WriteLine(Genrand.NextDouble());
            Console.WriteLine(Genrand.NextDouble());
        }
    }
}
