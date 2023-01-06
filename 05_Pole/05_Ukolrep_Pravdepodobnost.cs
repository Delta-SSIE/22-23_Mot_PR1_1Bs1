using System;

namespace pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            //Pole musí být double, aby šlo pak řešit pravděpodobnost
            double[] hodykostkou = { 0, 0, 0, 0, 0, 0 };

            Random hod = new Random();
            int cislo = 0;

            for (int i = 0; i < n; i++)
            {
                cislo = hod.Next(1, 7);
                //Zvyšuji hodnotu prvku pole, který mi stojí za dané číslo. A protože pole zařčíná od 0 a ne od 1, pak musím index-1
                hodykostkou[cislo - 1]++; 

            }

            Console.WriteLine($"Jednička byla hozena {hodykostkou[0]}; " +
                $"Dvojka byla hozena {hodykostkou[1]}; " +
                $"Trojka byla hozena {hodykostkou[2]}; " +
                $"Čtyřka byla hozena {hodykostkou[3]}; " +
                $"Pětka byla hozena {hodykostkou[4]}; " +
                $"Šestka byla hozena {hodykostkou[5]}; ");

            Console.WriteLine("Pravděpodobnost: ");

            //Pravděpodobnost se lišší od výpisu počtu hodů pouze tím, že jí dělím celým počtem hodů.
            Console.WriteLine($"Jednička {hodykostkou[0]/n}; " +
                 $"Dvojka {hodykostkou[1]/n}; " +
                   $"Trojka {hodykostkou[2]/n}; " +
                 $"Čtyřka  {hodykostkou[3]/n}; " +
            $"Pětka {hodykostkou[4]/n}; " +
            $"Šestka {hodykostkou[5]/n}; ");
        }
    }
}