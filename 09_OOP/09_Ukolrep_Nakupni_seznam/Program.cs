using System;

namespace Nakupni_seznam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kód metody Main si jen prohlédněte ale neměňte

            Polozka[] seznam = new Polozka[3]; //nákupní seznam představuje pole se 3 položkami, zatím prázdnými

            Polozka vejce = new Polozka(); //vytvořím novou položku
            vejce.Nazev = "vejce";
            vejce.Pocet = 12;
            seznam[0] = vejce; //uložím ji do seznamu

            seznam[1] = new Polozka(); // mohu i bez dočasné proměnné
            seznam[1].Nazev = "rohlíky";
            seznam[1].Pocet = 10;

            seznam[2] = new Polozka
            {
                Nazev = "chleba",
                Pocet = 1
            };

            VypisSeznam(seznam);

            //teď je seznam naplněn. Dokážete ho vypsat?
        }

        public static void VypisSeznam(Polozka[] nakupniSeznam)
        {
            //Výpis pomocí foreach
            foreach (Polozka a in nakupniSeznam)
            {
                Console.WriteLine($"{a.Pocet}x {a.Nazev}");
            }

            //Výpis pomocí for cyklu
            for (int i = 0; i < nakupniSeznam.Length; i++)
            {
                Console.WriteLine($"{nakupniSeznam[i].Pocet}x {nakupniSeznam[i].Nazev}");
            }
        }
    }
    }

