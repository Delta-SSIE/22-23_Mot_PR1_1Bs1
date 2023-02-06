using System;

namespace Dojezd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nadrz = 52;
            double spotreba = 7.2;

            Console.WriteLine(
                "Automobil s {0} litry benzínu a spotřebou {1} dojede nejvýše {2:0.0} kilometrů.",
                nadrz,
                spotreba,
                Dojezd(nadrz, spotreba)
            );
        }

        static double Dojezd(double palivo, double spotreba)
        {
            return palivo / spotreba * 100;

        }

    }
}
