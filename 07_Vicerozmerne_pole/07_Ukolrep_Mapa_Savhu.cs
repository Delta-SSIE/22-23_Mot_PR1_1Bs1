using System;

namespace mapa_svahu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VypisPole(Svah(4));
            VypisPole(Svah(10));
            VypisPole(SikmySvah(5));

        }

        //metoda pro výpis svahu
        static int[,] Svah(int velikost)
        {
            //Vytvoří se 2D pole, které jelikož je čtverec bude mít stejný počet řádků i sloupců, dle hodnoty velikot
            int[,] svah = new int[velikost, velikost];

            //Dva for cykly pro průchod 2D pole
            for (int i = 0; i < svah.GetLength(0); i++)
            {
                for (int j = 0; j < svah.GetLength(1); j++)
                {
                    //Do nového 2D pole svah se načítá vždy hodnota indexu daného sloupce.
                    svah[i, j] = j;
                }
            }
            return svah;
        }

        static int[,] SikmySvah(int velikost)
        {
            //Vytvoří se 2D pole, které jelikož je čtverec bude mít stejný počet řádků i sloupců, dle hodnoty velikot
            int[,] svah = new int[velikost, velikost];

            //Dva for cykly pro průchod 2D pole
            for (int i = 0; i < svah.GetLength(0); i++)
            {
                for (int j = 0; j < svah.GetLength(1); j++)
                {
                    //Do nového 2D pole svah se načítá vždy hodnota indexu daného sloupce + řádku, aby se vytvořil posun u šikmého svahu.
                    svah[i, j] = j+i;
                }
            }
            return svah;
        }

        //výpis je hotov
        public static void VypisPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
