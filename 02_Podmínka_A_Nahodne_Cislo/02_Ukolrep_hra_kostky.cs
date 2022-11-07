using System;

namespace hra_kostky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Kostka = new Random();
            int hodpocitace = Kostka.Next(1, 7);

            Console.WriteLine("hoď kostkou");
            Console.ReadKey();
            int hodhrace = Kostka.Next(1, 7);

            if (hodhrace == hodpocitace)
            {
                Console.WriteLine($"{hodpocitace}:{hodhrace} (Remíza)");
            } else if (hodhrace > hodpocitace)
            {
                Console.WriteLine($"{hodpocitace}:{hodhrace} (Vyhrál jsi)");
            } else
            {
                Console.WriteLine($"{hodpocitace}:{hodhrace} (Prohrál jsi)");
            }
        }
    }
}
