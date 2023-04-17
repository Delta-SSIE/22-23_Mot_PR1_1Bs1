using System;

namespace Zaklad_Zapouzdreni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Honza = new Person();

            Honza.Vyska = 251;
            Console.WriteLine(Honza.Vyska + " m");
        }
    }
}
