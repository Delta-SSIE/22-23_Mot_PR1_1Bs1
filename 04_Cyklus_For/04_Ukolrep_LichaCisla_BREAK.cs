using System;

namespace Nacti_licha_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sud = 0;
            Console.Write("Kolik čísel budeš chtít zapsat? ");
            int pocetcisel = int.Parse(Console.ReadLine());

            for (int i = 0; i < pocetcisel; i++)
            {
                Console.Write("Zadej liché číslo ");
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    sud = 1;
                    break;
                }
            }

            if (sud == 1)
            {
                Console.WriteLine("Zadal si sudé číslo!");
            } else
            {
                Console.WriteLine("Gratuluji, všecha čísla byla lichá!");
            }

         
        }
    }
}
