using System;

namespace Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tohle je komentář - následující řádek kódu vypíše "Ahoj světě!" do konzole
            Console.WriteLine("Ahoj světě!");
            /*
             * Tohle 
             * je komentář 
             * na více řádků
             */
            Console.WriteLine("Ahoj Evropo!");

            //Write vypisuje do jednoho řádku
            Console.Write("Ahoj");
            Console.WriteLine(" Jane");

            //Výpis čísla bez uvozovek
            Console.WriteLine(3);

            //Deklarace proměnné (string)
            string name = "Filip";
            //Výpis proměnné
            Console.WriteLine(name);

            //Deklarace proměnné (int)
            int cislo = 17;
            //Výpis proměnné
            Console.WriteLine(cislo);

            //Přepis proměnné
            cislo = 12;
            //Výpis proměnné
            Console.WriteLine(cislo);

            //Sčítání x + y = vysledek
            int x = 25;
            int y = 5;
            int vysledek = x + y;
            //Výpis proměnných a textu
            Console.WriteLine("Součet čísla " + x + " a " + y + " se rovná " + vysledek);

            //Dělení čísel x a y
            vysledek = x / y;
            Console.WriteLine("Podíl čísla " + x + " a " + y + " se rovná " + vysledek);

            //Deklarace proměnných jednoho typu
            int a = 5, b = 6, c = 5;
            //Vložení jedné hodnoty do více proměnných
            a = b = c = 50;
            //Výpis
            Console.WriteLine(a + b + c);

            
        }
    }
}
