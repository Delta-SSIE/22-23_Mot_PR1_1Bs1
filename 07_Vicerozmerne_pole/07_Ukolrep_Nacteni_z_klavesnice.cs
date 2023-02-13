using System;

namespace Nacti_pole_z_klavesnice
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                //do tohoto kódu nezasahujte
                int radky = 4;
                int sloupce = 3;
                int[,] tabulka = Nacti2DPole(radky, sloupce);
                Vypis2DPole(tabulka);
            }

            //sem přijde kód vaší metody
            static int[,] Nacti2DPole(int radky, int sloupce)
        {
            //Vytvořil jsem si dvojrozměrné pole o zadaném počtu řádků a sloupců
            int[,] tabulka = new int[radky, sloupce];
            
            //Procházení dvourozměřného pole
            for (int i = 0; i < tabulka.GetLength(0); i++)
            {
                for (int j = 0; j < tabulka.GetLength(1); j++)
                {
                    //Dotaz na zadání čísla (pozice vždy +1 kvůli posunu mezi indexy a pozicí)
                    Console.WriteLine($"Řádek {i + 1}, sloupec {j + 1} - zadej číslo:");
                    int a = int.Parse(Console.ReadLine());
                    //Vložení porvku do dvourozměrného pole
                    tabulka[i, j] = a;
                }
            }
            //Vrácení dvourozměrného pole
            return tabulka;
        }

            //konec vašeho kódu

            public static void Vypis2DPole(int[,] pole)
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
