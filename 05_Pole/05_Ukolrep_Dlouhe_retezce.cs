using System;

namespace Dlouhe_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankaslov = new string[5];

            for (int i = 0; i < bankaslov.Length; i++)
            {
                Console.WriteLine($"Zadej {i+1}.řetězec");
                bankaslov[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Nyní se vypíšou slova, která mají 6, či více znaků:");
            foreach (string i in bankaslov)
            {
                if(i.Length >= 6)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
