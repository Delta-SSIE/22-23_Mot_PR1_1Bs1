using System;

namespace cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 9999999;
            int souclich = 0;
            int soucsud = 0;
            int cislo;

            do
            {
                Console.Write("Zadej číslo (0 pro konec) ");
                cislo = int.Parse(Console.ReadLine());
                if (cislo % 2 == 0)
                {
                    soucsud += cislo;
                }
                else
                {
                    souclich += cislo;
                }
                max = Math.Max(max, cislo);
                if (cislo != 0) { 
                min = Math.Min(min, cislo);
                }
            } while (cislo != 0);

            Console.WriteLine($"Součet sudých čísel je {soucsud} \nSoučet lichých čísel je {souclich} \nNejvětší číslo je {max} \nNejmenší číslo je {min}");
        }
    }
}
