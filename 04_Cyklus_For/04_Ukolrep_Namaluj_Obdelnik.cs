using System;

namespace Obdelnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej stranu a, neboli šířku obdelníku ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej stranu b, neboli výšku obdelníku ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Cyklus řeší výšku obdelníku
            for (int i = 0; i < b; i++)
            {
                //Cyklus řeší šířku obdelníku
                for (int x = 0; x < a; x++)
                {
                    Console.Write("#");
                }
                //Zalomení řádku
                Console.WriteLine("");
            }
        }
    }
}
