using System;

namespace Secti_sud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soucet = 0;
            int a = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Napiš mi číslo ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    soucet += a;
                }
            }
            Console.WriteLine("Součet sudých čísel je {0} a poslední zadané číslo bylo {1}", soucet, a);

        }
    }
}
