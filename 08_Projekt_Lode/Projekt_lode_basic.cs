using System;

namespace lode_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] planek = Naplnpole0(4,4);
            int[,] hracipole = Naplnpole0(4, 4);

            hracipole = RozmistLode(hracipole, 4, 1);

            for (int i = 0; i < hracipole.GetLength(0); i++)
            {
                for (int j = 0; j < hracipole.GetLength(1); j++)
                {
                    Console.Write(hracipole[i, j]);
                }
                Console.WriteLine();

            }

        }

        static int[,] Naplnpole0(int x, int y)
        {
            int[,] pole = new int[x, y];

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = 0;
                }

            }

            return pole;
        }
        static int[,] RozmistLode(int[,] hracpole, int pocetlode, int velikostlode)
        {
            Random generator = new Random();
            int pozicex = generator.Next(0, hracpole.GetLength(1));
            int pozicey = generator.Next(0, hracpole.GetLength(0));
            for (int i = 0; i < pocetlode; i++)
            {
                while (hracpole[pozicey, pozicex] == 1)
                {
                  pozicex = generator.Next(0, hracpole.GetLength(1));
                  pozicey = generator.Next(0, hracpole.GetLength(0));
                }

                hracpole[pozicey, pozicex] = velikostlode;
            }

            return hracpole;
        }
    }
}
