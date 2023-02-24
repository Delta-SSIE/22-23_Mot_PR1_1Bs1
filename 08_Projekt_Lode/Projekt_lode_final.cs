using System;
using System.Runtime.Intrinsics.X86;

namespace lode_enhanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] planek = Naplnpole0(4,4);
            int[,] hracipole = Naplnpole0(4, 4);

            int pocetlodi = 4;
            hracipole = RozmistLode(hracipole, pocetlodi, 1);


            while (pocetlodi > 0)
            {
                Console.WriteLine("HRACÍ PLÁN");
                VypisPole(planek);
                Console.WriteLine($"Stávají počet lodí je {pocetlodi}");
                //Testovací vypsání hracího pole
                VypisPole(hracipole);
                hracipole = TahHrace(planek, hracipole);
                planek = UpravPlanek(planek, hracipole);
                pocetlodi = PoctyLodi(hracipole, 1);
                Console.Clear();
            }
            Console.WriteLine("Konec hry!");
        }

        //Metoda pro sčítání počtu lodí na hracím poli

        static int PoctyLodi(int[,] pole, int velikostlode)
        {
            int pocetlodi = 0;
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if (pole[i, j] == velikostlode)
                    {
                        pocetlodi++;
                    }
                }
            }
            return pocetlodi;
        }

        //Metoda pro úpravu plánku
        static int[,] UpravPlanek(int[,] planek, int[,] hracipole)
        {
            for (int i = 0; i < hracipole.GetLength(0); i++)
            {
                for (int j = 0; j < hracipole.GetLength(1); j++)
                {
                    if (hracipole[i,j] == 5)
                    {
                        planek[i, j] = 1;
                    }
                }
            }
            return planek;
        }

        //Metoda pro hráčovo kolo
        static int[,] TahHrace(int[,] planek, int[,] hracipole)
        {
            int podminkavelikost = 1;
            int podminkavystreleno = 1;
            int x = 0;
            int y = 0;
            while (podminkavelikost == 1 || podminkavystreleno == 1)
            {
                podminkavelikost = 1;
                podminkavystreleno = 1;
                Console.WriteLine("Kam chceš střílet na souřanicích X?");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Kam chceš střílet na souřanicích Y?");
                y = int.Parse(Console.ReadLine());
                x--;
                y--;

                podminkavelikost = Kontrolavelikost(x, y, planek);
                if (podminkavelikost == 0)
                {
                    podminkavystreleno = Kontrolazasah(x, y, planek);
                }
            }

            if (hracipole[y,x] == 1)
            {
                Console.WriteLine("Zásah!");
                // 5 = zásah
                hracipole[y, x] = 5;
            } else
            {
                Console.WriteLine("Minul jsi!");
                hracipole[y, x] = 5;
            }

            return hracipole;
           

        }

        //Metoda kontrola velikosti pole, jestli nestřílí mimo
        static int Kontrolavelikost(int x, int y, int[,] pole)
        {
             if (pole.GetLength(0) > y && pole.GetLength(1) > x && y >= 0 && x >= 0)
             {
                return 0;
                } else
            {
                Console.WriteLine("Dáváš nesmyslné souřadnice!");
                Console.ReadKey();
                return 1;
            }
        }

        //Metoda kontrola zásahu, aby nestřílel, kde už bylo vytřeleno

        static int Kontrolazasah(int x, int y, int[,] pole)
        {
            if (pole[y, x] != 1)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Sem si už střílel!");
                Console.ReadKey();
                return 1;
            }
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
