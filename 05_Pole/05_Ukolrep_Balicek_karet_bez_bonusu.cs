using System;

namespace balicek_karet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barva = { "listy", "kule", "žaludy", "srdce" };
            string[] vyska = { "sedma", "osma", "devět", "deset", "spodek", "svršek", "král", "eso" };
            string[] balicek = new string[32];
            int index = 0;

            //Foreach pro procházení po barvách (vnější cyklus)
            foreach (string b in barva)
            {
                //Foreach pro procházení po výškách (vnitřní cyklus)
                foreach (string v in vyska)
                {
                    //Zapsaní do třetího pole
                    balicek[index] = b + " - " + v;
                    //zvyšení indexu por třetí pole
                    index++;
                }

            }

            //Výpis pole balíček pomocí foreach
            foreach (string karta in balicek)
            {
                Console.WriteLine(karta);
            }
        }
    }
}
