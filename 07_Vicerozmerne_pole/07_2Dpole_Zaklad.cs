using System;

namespace _2D_pole_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole o 3 řádcích a 4 sloupcích
            int[,] pole2d = { {1,2,3,4 },{5,6,7,8 },{9,10,11,12 } };

            //Výpis 2 řádků 1 prvku!
            Console.WriteLine(pole2d[1, 0]);

            //Změna hodnota v 2D poli
            pole2d[1, 0] = 10;
            Console.WriteLine(pole2d[1, 0]);

            //Foreach pro průchod polem
            foreach  (int a in pole2d)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();

            //Výpis počtu řádků a sloupců
            Console.WriteLine(pole2d.GetLength(0));
            Console.WriteLine(pole2d.GetLength(1));


            //Průchod pomocí for
            for (int i = 0; i < pole2d.GetLength(0); i++)
            {
                for (int j = 0; j < pole2d.GetLength(1); j++)
                {
                    Console.Write(pole2d[i,j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
