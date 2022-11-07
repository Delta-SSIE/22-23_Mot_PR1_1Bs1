using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstup;
            int stenykostky;
            int pocethod;
            int hod = 0;
            int soucethod = 0;
            int aktualnihod;
            Random kostka = new Random();

            //TryParse na ovaření toho, že se jedná o číslo, plus jsem přidal, aby hlídalo, že zadal funkční počet stěn (kostka má aspoň 2 (mince))
            do
            {
                Console.Write("Počet stěn kostky ");
                vstup = Console.ReadLine();
            } while (!int.TryParse(vstup, out stenykostky) && stenykostky > 1);

            //TryParse na ovaření toho, že se jedná o číslo, plus to hlídá, že vloží větší číslo než 0, aspoň jednou musí hodit.
            do
            {
                Console.Write("Napiš počet hodů ");
                vstup = Console.ReadLine();
            } while (!int.TryParse(vstup, out pocethod) && pocethod > 0);

            while (hod != pocethod)
            {
                hod++;
                aktualnihod = kostka.Next(1, (stenykostky + 1)); //horní hranici musím zvýšit o jedna
                soucethod += aktualnihod;

            }

            Console.WriteLine($"Celkově bylo hozeno {hod}krát {stenykostky}-stěnnou kostkou. Průměrný výsledek hodu je {soucethod / hod}");
      

        }
    }
}
