using System;

namespace Druha_pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Statný valach ojnici zničil. Révou zhrdla žena ostrovana Claudia Pompeia. Ozvučení hnědé místnosti okamžitě zvýraznit! Běžný statkář to zvládne. Japonec Anihito rád označoval čárami. Asi sto pět kravských žaludků";
            //Tady se do nového pole textrozsek vloží na jednotlivé pozice slova (vždy se vloží string a další pozice se oddělí mezerou)
            string[] textrozsek = text.Split(' ');

            //Cyklus na průchod pole textrozsek
            foreach (string i in textrozsek)
            {
                //Výpis pouze znaku na 1. indexu (2 pozice) daného stringu.
                Console.Write(i[1]);
            }
        }
    }
}
