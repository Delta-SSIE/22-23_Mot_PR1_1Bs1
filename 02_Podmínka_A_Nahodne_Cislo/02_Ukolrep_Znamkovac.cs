using System;

namespace Znamkovac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik procent žák získal? ");
            double znamka = double.Parse(Console.ReadLine());

            if (znamka >= 101)
            {
                Console.WriteLine("Zadaná procenta nedávají smysl");
            } else if (znamka >= 83)
            {
                Console.WriteLine("Má výbornou");
            } else if (znamka >= 67)
            {
                Console.WriteLine("Má chvalitebnou");
            } else if (znamka >= 50)
            {
                Console.WriteLine("Má dobrou");
            } else if (znamka >= 33)
            {
                Console.WriteLine("Má Dostatečnou");
            } else
            {
                Console.WriteLine("Má Nedostatečnou");
            }
            Console.ReadKey();

        }
    }
}
