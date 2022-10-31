using System;

namespace While_Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("zadej jeden kraj intervalu:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("zadej druhý kraj intervalu:");
            int b = int.Parse(Console.ReadLine());

            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            int sum = 0;
            min++;

            while (min != max)
            {
                sum += min;
                min++;
            }

            Console.WriteLine($"Součet čísel v intervalu je {sum}");

        }
    }
}
