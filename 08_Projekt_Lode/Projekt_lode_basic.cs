using System;
using System.Runtime.Intrinsics.X86;

namespace lode_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] planek = Naplnpole0(4,4);
            int[,] hracipole = Naplnpole0(4, 4);

            hracipole = RozmistLode(hracipole, 4, 1);
            int pocetlodi = 4;

            while (true)
            {
                Console.WriteLine("HRACÍ PLÁN");
                VypisPole(planek);
                Console.WriteLine($"Stávají počet lodí je {pocetlodi}");
         
            }

            //Testovací vypsání hracího pole
            VypisPole(hracipole);

        }

        //Metoda na výpis pole
        static void VypisPole(int[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();

            }
        }

        //Metoda na naplnění pole o zadaných rozměr nulami
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

        //Metoda náhodného rozmístění zadaného počtu lodí o zadané velikosti
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
