using System;

namespace pruzkum_tolerance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sousedi = { "Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {
            {  true, false, false, false,  true,  true, true,  true },
            {  true,  true,  true,  true,  true, false, true,  true },
            {  true,  true, false,  true,  true,  true, true, false },
            { false,  true,  true,  true,  true, false, true,  true },
            {  true, false, false,  true, false, false, true, false },
            {  true, false, false,  true,  true, false, true, false },
            {  true, false, false,  true, false, false, true,  true },

        };
            int popularni = PopularitaSouseda(vysledky, "T");
            Console.WriteLine($"Nejoblibenější rasa souseda je {sousedi[popularni]}");
            int nepupularni = PopularitaSouseda(vysledky, "F");
            Console.WriteLine($"Nejméně oblíbená rasa souseda je {sousedi[nepupularni]}");

            int tolerantni = ToleranceRespondenta(vysledky, "T");
            Console.WriteLine($"Nejvíce tolerantní je {respondenti[tolerantni]}");
            int netolerantni = ToleranceRespondenta(vysledky, "F");
            Console.WriteLine($"Nejvíce tolerantní je {respondenti[netolerantni]}");
        }

        static int ToleranceRespondenta(bool[,] sousedi, string anocine)
        {
            //Pole, kde budu sčítat jednotlivé true/false u daných respondentů
            int[] respondenti = { 0, 0, 0, 0, 0, 0, 0 };

            //Pomocí dvou for cyklů prochází 2D pole
            for (int i = 0; i < sousedi.GetLength(0); i++)
            {
                for (int j = 0; j < sousedi.GetLength(1); j++)
                {
                    //Pokud je hodnota true/false (podle parametru anocine), pak se zvedne hodnota v poli rasy. Index je roven indexu sloupce.

                    if (anocine == "F")
                    {
                        if (sousedi[i, j] == false)
                        {
                            respondenti[i]++;
                        }
                    }
                    else
                    {
                        if (sousedi[i, j] == true)
                        {
                            respondenti[i]++;
                        }
                    }

                }
                }

                int maxid = 0;

                //Prohledání pole respondenti a hledání největší hodnoty v daném poli
                for (int i = 1; i < respondenti.Length; i++)
                {
                    if (respondenti[i] > respondenti[maxid])
                    {
                        maxid = i;
                    }
                }

                //Vrácení indexu
                return maxid;
            }

        
        static int PopularitaSouseda(bool[,] sousedi, string popularni)
        {
            //Pole pro sčítání true u jednotlivých odpovědí pro dané rasy
            int[] rasy = { 0, 0, 0, 0, 0, 0, 0, 0 };

            //Pomocí dvou for cyklů prochází 2D pole
            for (int i = 0; i < sousedi.GetLength(0); i++)
            {
                for (int j = 0; j < sousedi.GetLength(1); j++)
                {
                    //Pokud je hodnota true/false (podle parametru popularni), pak se zvedne hodnota v poli rasy. Index je roven indexu sloupce.
                    if (popularni == "F")
                    {
                        if (sousedi[i, j] == false)
                        {
                            rasy[j]++;
                        }
                    } else
                    {
                        if (sousedi[i, j] == true)
                        {
                            rasy[j]++;
                        }
                    }

                 
                }
            }

            int maxid = 0;

            //Prohledání pole rasy a hledání největší hodnoty v daném poli
            for (int i = 1; i < rasy.Length; i++)
            {
                if (rasy[i] > rasy[maxid])
                {
                    maxid = i;
                }
            }

            //Vrácení indexu
            return maxid;
        }
    }
}
