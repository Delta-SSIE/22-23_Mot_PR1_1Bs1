using System;
using System.Linq;

namespace nejvetsi_cislo_met
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cislo1 = 1.3;
            double cislo2 = 4.6;
            double cislo3 = -3.3;
            double maximum = Nejvetsi(cislo1, cislo2, cislo3);
            Console.WriteLine($"Největší ze zadaných čísel je {maximum}.");
        }

        static double Nejvetsi(double x, double y, double z)
        {
            double[] polecisel = { x, y, z };
            return polecisel.Max();
        }
    }
}
