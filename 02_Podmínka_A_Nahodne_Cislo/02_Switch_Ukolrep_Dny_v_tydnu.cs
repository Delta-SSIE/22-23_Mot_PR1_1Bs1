using System;

namespace Switch_Den_v_tydnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jaký je den? (povolené vstupy 1–7)");
            int den = int.Parse(Console.ReadLine());

            switch(den)
            {
                case 1:
                    Console.WriteLine("Je pondělí");
                    break;
                case 2:
                    Console.WriteLine("Je úterý");
                    break;
                case 3:
                    Console.WriteLine("Je středa");
                    break;
                case 4:
                    Console.WriteLine("Je čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Je pátek");
                    break;
                case 6:
                    Console.WriteLine("Je sobota");
                    break;
                case 7:
                    Console.WriteLine("Je neděle");
                    break;
                default:
                    Console.WriteLine("Zadal jste nesmyslné číslo!");
                    break;
            }
        }
    }
}
