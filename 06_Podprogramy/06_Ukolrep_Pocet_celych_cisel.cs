using System;

namespace pole_celych_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.3, 1.7, 2, 3.1, 0.1, -1 };
            //obsahuje 2 celá čísla, 2 a -1

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla),
                PocetCelych(cisla)
                );
        }

        static int PocetCelych(double[] pole)
        {
            int pocet = 0;
            foreach (double a in pole)
            {
                if (a % 1 == 0)
                {
                    pocet++;
                }
            }
            return pocet;
        }
    }
}
