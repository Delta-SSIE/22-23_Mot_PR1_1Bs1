using System;

namespace Troj_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            for (int i = 0; i < strana; i++)
            {
                for (int x = i; x < strana; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
