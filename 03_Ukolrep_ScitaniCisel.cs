using System;

namespace While_scitanicisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já je budu sčítat. Vložení 0 program ukončí.");
            int vstup = 2;
            int soucet = 0;
            while (vstup != 0)
            {
                vstup = int.Parse(Console.ReadLine());
                //Zkracený zápis pro soucet = soucet + vstup
                soucet += vstup;
            }

            Console.WriteLine($"Součet čísel je {soucet}");
        }
    }
}
