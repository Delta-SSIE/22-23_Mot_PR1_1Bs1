using System;
using System.Security.Cryptography.X509Certificates;

namespace cvic_res
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba nového objektu mojerestaurace z třídy Restaurant
            Restaurant mojerestaurace = new Restaurant("Super restaurace");
            //Pomocné proměnné pro metodu výpisu jídelníčku pro účastníky
            string[] ucastnici = { "Jakub", "Bedřich", "Lukáš", "Jidnřich", "Robert" };
            int[] kapesne = { 100, 80, 150, 200, 120 };

            //nekonečný cyklus pro menu
            while (true)
            {
                //Vyčištění obrazovky
                Console.Clear();
                int volba = 0;
                //Základní instrukce
                Console.WriteLine($"Vítejte v restauraci {mojerestaurace.name}");
                Console.WriteLine("Pro vypsání všech jídel zadej 1\nPro vypsání jídla dle podmínek zadej 2\nPro přidání jídla zadej 3\nPro odebrání jídla zadej 4\nPro výpis jídelníčku účastníků zadej 5");
                //Try pro odchycení zadání jiného vstupu než číslo
                try
                {
                    volba = int.Parse(Console.ReadLine());
                }catch
                {
                    Console.WriteLine("Zadal jste neplatný vstup");
                    Console.ReadKey();
                } 
                //If pro zahájení metody dle menu. ReadKey() potom drží uživatele, aby viděl výpis z metody.
                if(volba == 1)
                {
                    mojerestaurace.VypisJidlo();
                    Console.ReadKey();
                }
                if (volba == 2)
                {
                    mojerestaurace.VypisJidlo2();
                    Console.ReadKey();
                }
                if (volba == 3)
                {
                    mojerestaurace.PridejJidlo();
                    Console.ReadKey();
                }
                if (volba == 4)
                {
                    mojerestaurace.OdeberJidlo();
                    Console.ReadKey();
                }
                if (volba == 5)
                {
                    mojerestaurace.JidelnicekUcastniku(ucastnici, kapesne);
                    Console.ReadKey();
                }
            }
            


        }

     
    }
}
