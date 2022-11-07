using System;

namespace Priklad_IQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skore = 0;

            Console.Write("4 + 2 se rovná ");
            int a = int.Parse(Console.ReadLine());

            if (a == 6)
            {
                skore = skore + 5;
            } else
            {
                skore -= 3;
            }

            Console.WriteLine(skore);
        }
    }
}
