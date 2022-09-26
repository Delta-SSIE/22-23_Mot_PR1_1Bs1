using System;

namespace VysledkyTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bonusová úloha větší a menší
            Console.Write("Zadej číslo X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Zadej číslo Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Číslo X je vyšší než číslo Y: ");
            Console.WriteLine(x > y);
            Console.Write("Číslo Y je vyšší než číslo X:: ");
            Console.WriteLine(x < y);
            Console.Write("Číslo Y je rovno číslu X: ");
            Console.WriteLine(x == y);


            //Obsah a obvod
            Console.WriteLine("Zadejte poloměr kruhu v cm!");
            double polomer = Convert.ToDouble(Console.ReadLine());
            // Math.Round zaokrolouhluje; Math.PI zadává číslo Pi; Math.Pow(cislo, mocnitel)
            double obsah = Math.Round(Math.PI * Math.Pow(polomer, 2), 2);
            double obvod = Math.Round((Math.PI * polomer * 2), 2);
            Console.WriteLine($"Obvod kruhu je {obvod} cm a obsah kruhu je {obsah} cm^2.");
        }
    }
}
