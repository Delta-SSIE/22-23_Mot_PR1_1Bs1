using System;

namespace Nakup_2_0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Tento úkol se silně podobá cvičení Nákup, které jste už jednou tvořili. Ovšem nenechte se unést na této podobnosti a pečlivě čtěte zadání, neboť se od úkolu z cvičení v některých místech odchyluje.

Vytvoř program, který bude fungovat jako nákupní list. Program po zapnutí se uživatel zeptá, jestli chce na nákupní seznam přidat rohlík, housku, či chleba. Cena zboží se lišší – rohlík stojí 3, tak houska 5 a chleba 10 korun. Uživatel na otázku odpoví – r/h/ch – pokud uživatel zadá jiný vstup, tak ho program vyzve k opětovnému zadání typu zboží, co chce přidat na seznam.

Ve chvíli, kdy uživatel vloží správný vstup pro jednotlivý kus zboží (r/h/ch), tak se program zeptá na to kolik položek daného zboží chce koupit. Od uživatele se očekává přirozené číslo, pokud zadá cokoliv jiného (včetně čísla záporného, či nuly), tak program uživatele vyzve k novému zadání čísla, dokud jej opravdu nezadá. V tu chvíli se na seznam přidá počet položek daného typu, který uživatel zadal.

Psaní položek na seznam ukončí buď to, že uživatel místo možnosti při výběru typu zboží zadá "X", či pokud celkový počet položek (součet všeho, co koupil) překročí 50 kusů. V obou případech se zapisování zastaví a uživateli se vypíše kolik položek jednotlivých typů zboží je na jeho nákupním seznamu a jaká je celková cena jeho nákupu.
             */

            string vstup;
            int pocetzbozi = 0;
            int pocetroh = 0;
            int pocethousek = 0;
            int pocetchleb = 0;
            int cena = 0;
            int celkovacena = 0;
            string pocetkus;
            int pocetkuscislo;

            do
            {
                cena = 0;

                Console.Write("Zadej typ zboží, co chceš koupit (r/h/ch), či X pro ukončení: ");
                vstup = Console.ReadLine();

                if (vstup == "r")
                {
                    cena = 3;
                }
                else if (vstup == "h")
                {
                    cena = 5;
                }
                else if (vstup == "ch")
                {
                    cena = 10;
                }

                if (cena != 0)
                {
                    do
                    {
                        Console.Write("Zadej počet kusů ");
                        pocetkus = Console.ReadLine();
                    } while (!int.TryParse(pocetkus, out pocetkuscislo) && pocetkuscislo <= 0);

                    celkovacena += cena * pocetkuscislo;
                    pocetzbozi += pocetkuscislo;

                    if (cena == 3)
                    {
                        pocetroh += pocetkuscislo;
                    }
                    else if (cena == 5)
                    {
                        pocethousek += pocetkuscislo;
                    }
                    else if (cena == 10)
                    {
                        pocetchleb += pocetkuscislo;
                    }

                }

            } while (pocetzbozi <= 50 && vstup != "X");

            Console.WriteLine($"Celková cena nákupu je {celkovacena}\nPočet zboží celkově je {pocetzbozi}\nPočet housek je {pocethousek}\nPočet rohlíku je {pocetroh}\nPočet chlebů je {pocetchleb}");
        }
    }
}
