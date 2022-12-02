using System;

namespace Trojuhelnik._komplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Určuje výšku trojúhelníku
            int vyska = 10;
            int pocetmezer = 0;
            int pocetznaku = 0;

            //Vnější cyklus řeší skoky po řádcích
            for (int i = 0; i < vyska; i++)
            {
                pocetmezer = vyska - i;
                pocetznaku = (i*2)+1;

                //vypisuje mezery na daném řádku
                for (int x = 0; x < pocetmezer; x++)
                {
                    Console.Write(" ");
                }

                //vypisuje znaky na daném řádku
                for (int y = 0; y < pocetznaku; y++)
                {
                    Console.Write("#");
                }

                //udělá odskok na nový řádek
                Console.WriteLine();
         
            }
        }
    }
}
