using System;

namespace Ukolrep_Bankovni_ucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba objektu pomocí konstruktoru
            BankAccount mujucet = new BankAccount(1, "Honza", 1000, "Studentsky");

            //Nekonečná smyčka
            while (true)
            {
                int volba = 0;
                //Vyčištění konzole
                Console.Clear();
                //Výpis základních informací o účtu
                Console.WriteLine($"Vítej {mujucet.AccountHolderName} s pořadovým číslem účtu {mujucet.AccountNumber}." +
                    $" na vašem účtu zbývá {mujucet.AccountBalance} a typ účtu je {mujucet.AccountType}");
                //Jednoduchý menu pro další kroky
                Console.WriteLine("Pro výběr napiš 1\nPro vklad napiš 2");
                //Řešení výjimky, pokud by zadal něco, co není číslo
                try
                {
                    volba = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Zadali jste špatně!");
                    Console.ReadKey();
                }
                //Podmínka pro správu menu
                if (volba == 1)
                {
                    //Dotaz na to kolik chce vybrat
                    Console.WriteLine("Kolik chceš vybrat?");
                    int castka = int.Parse(Console.ReadLine());
                    //Zavolání metody Withdrawal
                    mujucet.Withdrawal(castka);
                    Console.ReadKey();
                } else if (volba == 2)
                {
                    //Dotaz na to kolik chce vložit
                    Console.WriteLine("Kolik chceš vložit?");
                    int castka = int.Parse(Console.ReadLine());
                    //Zavolání metody Deposit
                    mujucet.Deposit(castka);
                    Console.ReadKey();
                }
     
            }
        }
    }
}
