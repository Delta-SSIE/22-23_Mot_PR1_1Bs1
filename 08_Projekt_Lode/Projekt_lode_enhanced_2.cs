using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace lode_enhanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej ve hře LODĚ");

            int velikostpole = -1;
            //While cyklus na vložení velikosti pole, pouští vstupu minimálně o velikosti 2
            while (velikostpole <= 1)
            {
                Console.WriteLine("Zadej velikost pole ve kterém chceš hrát!");
                velikostpole = int.Parse(Console.ReadLine());
            }

            int[,] planek = Naplnpole0(velikostpole, velikostpole);
            int[,] hracipole = Naplnpole0(velikostpole, velikostpole);
            int[,] hracovopole = Naplnpole0(velikostpole, velikostpole);

            int pocetlodi = 0;
            //While cyklus, který pustí jen hodnotu větší než 0, aby aspon jedna loď existovala a nepustí více lodí než se vejdou do pole!
            while (pocetlodi <= 0 || pocetlodi > Math.Pow(velikostpole, 2))
            {
                Console.WriteLine("Zadej počet lodí!");
                pocetlodi = int.Parse(Console.ReadLine());
            }

            hracovopole = VkladejLode(hracovopole, pocetlodi, 1);
            hracipole = RozmistLode(hracipole, pocetlodi, 1);
            int pocetlodihrac = pocetlodi;

            while (pocetlodi > 0 && pocetlodihrac > 0)
            {
                Console.WriteLine("HRACÍ PLÁN");
                VypisPole(planek);
                Console.WriteLine("HRAČOVO POLE");
                VypisPole(hracovopole);
                Console.WriteLine($"Stávají počet lodí soupeře {pocetlodi}");
                Console.WriteLine($"Stávají počet lodí hráče {pocetlodihrac}");
                //Testovací vypsání hracího pole
                //VypisPole(hracipole);
                hracipole = TahHrace(planek, hracipole);
                hracovopole = TahSoupere(hracovopole);
                planek = UpravPlanek(planek, hracipole);
                pocetlodi = PoctyLodi(hracipole, 1);
                pocetlodihrac = PoctyLodi(hracovopole, 1);
                Console.Clear();
            }
            Console.WriteLine("Konec hry!");

            if (pocetlodi == 0)
            {
                Console.WriteLine("Vyhrál hráč!");
            } else if (pocetlodihrac == 0) {
                Console.WriteLine("Vyhrál počítač!");
            }
        }

        //Metoda pro kolo soupeře (AI)
        static int[,] TahSoupere(int[,] hracipole)
        {
            int podminkavelikost = 1;
            int podminkavystreleno = 1;
            int x = 0;
            int y = 0;
            Random souradnice = new Random();
            while (podminkavelikost == 1 || podminkavystreleno == 1)
            {
                podminkavelikost = 1;
                podminkavystreleno = 1;
                x = souradnice.Next(0, hracipole.GetLength(1));
                y = souradnice.Next(0, hracipole.GetLength(0));
                podminkavelikost = Kontrolavelikost(x, y, hracipole);
                if (podminkavelikost == 0)
                {
                    podminkavystreleno = Kontrolazasah(x, y, hracipole, 5);
                }
            }
            if (hracipole[y, x] == 1)
            {
                Console.WriteLine("Počítač zasáhl!");
                Console.ReadKey();
                // 5 = zásah
                hracipole[y, x] = 5;
            }
            else
            {
                Console.WriteLine("Počítač minul!");
                Console.ReadKey();
                hracipole[y, x] = 5;
            }

            return hracipole;


        }

        //Metoda na romistování lodí hráčem
        static int[,] VkladejLode(int[,] pole, int pocetlodi, int velikostlode)
        {
            for (int i = 0; i < pocetlodi; i++)
            {
                Console.Clear();
                VypisPole(pole);
                int podminkavelikost = 1;
                int podminkavystreleno = 1;
                int x = 0;
                int y = 0;
                while (podminkavelikost == 1 || podminkavystreleno == 1)
                {
                    podminkavelikost = 1;
                    podminkavystreleno = 1;
                    Console.WriteLine("Zadej souřadnice nové lodi!");
                    Console.WriteLine("Zadej číslo sloupec (zleva doprava)!");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Zadej číslo řádku (odshora dolů)!");
                    y = int.Parse(Console.ReadLine());
                    x--;
                    y--;

                    podminkavelikost = Kontrolavelikost(x, y, pole);
                    if (podminkavelikost == 0)
                    {
                        podminkavystreleno = Kontrolazasah(x, y, pole, 1);
                    }
                }
                pole[y, x] = velikostlode;
            }
            Console.Clear();
            return pole;
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
                Console.WriteLine("Kam chceš střílet? Zadej číslo sloupec (zleva doprava)!");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Kam chceš střílet? Zadej číslo řádku (odshora dolů)!");
                y = int.Parse(Console.ReadLine());
                x--;
                y--;

                podminkavelikost = Kontrolavelikost(x, y, planek);
                if (podminkavelikost == 0)
                {
                    podminkavystreleno = Kontrolazasah(x, y, planek, 1);
                }
            }

            if (hracipole[y,x] == 1)
            {
                Console.WriteLine("Zásah!");
                Console.ReadKey();
                // 5 = zásah
                hracipole[y, x] = 5;
            } else
            {
                Console.WriteLine("Minul jsi!");
                Console.ReadKey();
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

        static int Kontrolazasah(int x, int y, int[,] pole, int typ)
        {
            if (pole[y, x] != typ)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Tohle místo nelze adresovat!");
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
