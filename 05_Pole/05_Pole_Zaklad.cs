using System;
using System.Linq;

namespace Pole_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole
            int[] polecisel;

            //Deklarace pole s pložkami
            string[] poletextu = {"Ahoj", "Cus", "Nazdar", "Zdar", "Pozdrav panbůh!"};

            //Deklarace pole s použitým new
            int[] nasobky2 = new int[] {2, 4, 6, 7, 8};

            //Výpis pole
            Console.WriteLine(poletextu[1]);
            Console.WriteLine(nasobky2[0]);

            //Přepis položky v poli
            poletextu[1] = "Čus";
            Console.WriteLine(poletextu[1]);
            nasobky2[0] = 0;
            Console.WriteLine(nasobky2[0]);

            //Incializace pole s zadanou velikostí
            int[] nasobky3 = new int[5] { 3, 6, 9, 12, 15};

            //Metody k práci
            
            //Velikost pole
            Console.WriteLine(nasobky3.Length);

            //Seřazení pole
            int[] nahodnacisla = { 10, 12, 5, 4, 8, 13, 23 };
            Console.WriteLine(nahodnacisla[0] + " " + nahodnacisla[1]);
            Array.Sort(nahodnacisla);
            Console.WriteLine(nahodnacisla[0] + " " + nahodnacisla[1]);

            //Nejvyšší hodnota v poli
            Console.WriteLine(nahodnacisla.Max());
            //Nejnižší hodnota v poli
            Console.WriteLine(nahodnacisla.Min());

            //Sečtení všech hodnot v poli
            Console.WriteLine(nahodnacisla.Sum());


            //Výpis pole (průchod polem)
            for (int i = 0; i < nahodnacisla.Length; i++)
            {
                Console.WriteLine($"Na {i}.indexu je číslo {nahodnacisla[i]}");
            }

            //Výpis pole pomocí foreach
            foreach (string i in poletextu)
            {
                Console.WriteLine(i);
            }

            //Výpis pole pomocí foreach pole čísel
            foreach (int i in nahodnacisla)
            {
                Console.WriteLine(i);
            }
        }
    }
}
