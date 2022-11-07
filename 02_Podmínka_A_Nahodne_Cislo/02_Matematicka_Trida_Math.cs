using System;

namespace Třída_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            int a = -15;
            float b = 4.5f;

            //Metoda Min a Max
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Max(x, y));

            //Odmocnina
            Console.WriteLine(Math.Sqrt(x));

            //Absolutní hodnota
            Console.WriteLine(Math.Abs(a));

            //Zaokrouhlení
            Console.WriteLine(Math.Round(b));

            //Mocnina
            Console.WriteLine(Math.Pow(x, y));

            //Číslo Pi a Euklidovo číslo
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
        }
    }
}
