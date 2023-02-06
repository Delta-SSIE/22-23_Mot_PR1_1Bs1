using System;

namespace kresleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
          {
            {  true, false, false,  true, false, false,  true},
            { false,  true, false,  true, false,  true, false},
            { false, false,  true,  true,  true, false, false},
            { false, false, false,  true, false, false, false},
        };

        VykresliPole(mapa);
            VykresliPole(mapa, "X", "-");
            VykresliPole(mapa, "1", "0");

        }

        static void VykresliPole(bool[,] kresleni, string znak = "#", string prazdnemisto = " ")
        {
            //Vnější cyklus chodí po jednotlivých řádcích 2D pole (index řádků je tedy i)
            for (int i = 0; i < kresleni.GetLength(0); i++)
            {
                //Vnitřní cyklus chodí po sloupcích 2D pole (index sloupce je tedy j)
                for (int j = 0; j < kresleni.GetLength(1); j++)
                {
                    if (kresleni[i, j])
                    {
                        Console.Write(znak);
                    } else
                    {
                        Console.Write(prazdnemisto);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
