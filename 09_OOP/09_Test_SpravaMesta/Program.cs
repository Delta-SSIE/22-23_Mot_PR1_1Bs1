using System;

namespace test_sprava_mesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City mesto = new City();

            for (int i = 0; i < 100; i++)
            {
                mesto.PridejObcana();
            }
            Console.WriteLine($"Ve městě je {mesto.population} občanů");
            mesto.VypisObcana();

          
        }
    }
}
