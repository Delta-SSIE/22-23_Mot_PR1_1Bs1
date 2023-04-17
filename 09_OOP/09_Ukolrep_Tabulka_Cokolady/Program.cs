using System;

namespace Tabulka_Cokolady
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabulka dobrota = new Tabulka();
              //zde nastavte další vlastnosti
            dobrota.Druh = "Mléčná";
             dobrota.Znacka = "Kráááva";
              dobrota.Hmotnost = 120;

                while (dobrota.Hmotnost > 0)
                {
                    int puvodni = dobrota.Hmotnost;
                    int odlomeno = dobrota.Odlom();
                    int zbyde = dobrota.Hmotnost;

                    Console.WriteLine($"Tabulka typu {dobrota.Druh} čokoláda měla hmotnost {puvodni} gramů, odlomili jsme {odlomeno} gramů a zbylo {zbyde} gramů.");
                }

                Tabulka macek = new Tabulka();
                //macek.SetHmotnost(3000);
                //až ověříte, že se správně testují hmotnosti a sami si doděláte jiné testy vlastností, kód si zakomentujte, ať nerozbíjí program
            }
        }
}
