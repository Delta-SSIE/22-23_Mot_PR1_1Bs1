using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 1, 3, 2, 4, 7, 12, 4 };

            //Cyklus na procházení pole
            for (int i = 0; i < hodnoty.Length; i++)
            {
                //Vypis začátku řádku, neboli index a dvojtečka.
                Console.Write($"{i}:");
                //Cyklus, který se opakuje podle toho jak vysoká je hodnota na daném indexu.
                for (int x = 0; x < hodnoty[i]; x++)
                {
                    //Při každém průchodu se vypíše jeden hash!
                    Console.Write("#");
                }
                //Zalomení řádku při přechodu na další index.
                Console.WriteLine();
            }
        }
    }
}
