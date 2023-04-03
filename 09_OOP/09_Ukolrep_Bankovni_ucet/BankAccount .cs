using System;
using System.Collections.Generic;
using System.Text;

namespace Ukolrep_Bankovni_ucet
{
    internal class BankAccount
    {
        //Veřejný (public) vlastnosti třídy BankAccount
        public int AccountNumber;
        public string AccountHolderName;
        public int AccountBalance;
        public string AccountType;
        
        //Konstruktor, který na začátku naplní vlastnosti nového objektu dané třídy hodnotami.
        public BankAccount(int number, string name, int balance, string type)
        {
            AccountNumber = number;
            AccountHolderName = name;
            AccountBalance = balance;
            AccountType = type;
        }

        //Veřejná metoda Deposit (vklad), který přičte k hodnotě AccountBalance zadanou hodnotu castka.
        public void Deposit(int castka)
        {
            AccountBalance = AccountBalance + castka;
            Console.WriteLine($"Váš nový zůstatek je {AccountBalance}");
        }

        //Veřejná metoda Witthdrawal(výběr), která odečte hodnotu castak od hodnoty ve vlastnosti AccountBalance.
        public void Withdrawal (int castka)
        {
            //Kontrola, jestli má dost peněz pro výběr.
            if (castka > AccountBalance)
            {
                Console.WriteLine("Nemáte dostatek peněz na účtu!");
            } else
            {
                AccountBalance = AccountBalance - castka;
                Console.WriteLine($"Váš nový zůstatek je {AccountBalance}");
            }
        }

    }
}
