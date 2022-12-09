using System;

namespace Podmineny_soucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 25, -56, -88, 5, 10, 65, 584, -8, -120, 18 };
            int soucet = 0;
            foreach (int i in cisla)
            {
                if (i <= 10 && i >= -10)
                {
                    soucet += i;
                }
            }

            Console.WriteLine($"Součet položek mezi hodnotami -10 a 10 je {soucet}");

        }
    }
}
