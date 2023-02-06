using System;

namespace diagonaly
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[,] diagonaly = { {"#"," "," ", " ", "#" },{" ", "#", " ", "#", " " },{" ", " ", "#", " ", " "}, { " ", "#", " ", "#", " " } , { "#", " ", " ", " ", "#" } };
            Vypis2DPole(diagonaly);

        }
        public static void Vypis2DPole(string[,] pole)
        {
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
