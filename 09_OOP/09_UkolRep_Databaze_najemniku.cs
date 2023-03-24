using System;

namespace databaze_najemcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] byty = { "", "Procházkovi", "Novotní", "Jedlička", "Jůzovi", "Zelená", "Zbyšek", "Starochovi", "Mladěnová" };

            Console.WriteLine("Služba \"Výpis rodin\" vám odpoví na otázku, kdo bydlí v našem domě. Vložte číslo bytu, které chcete znát, nebo 0 pro ukončení aplikace.");
            do
            {
                Console.WriteLine();
                Console.Write("Zadejte číslo bytu: ");

                string prikaz = Console.ReadLine();

                if (prikaz == "0")
                    break;
                try
                {
                    int cisloBytu = int.Parse(prikaz);
                    Console.WriteLine($"V bytě číslo {cisloBytu} bydlí {byty[cisloBytu]}.");
                }
                //Vyjimka k tomu, pokud je index mimo rozsah pole
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Zadal jsi číslo, které v domě není!");
                }
                //Vyjimka k tomu, pokud se jedná o špatně zadaný formát vstupu
                catch (System.FormatException)
                {
                    Console.WriteLine("Zadal si jiný vstup, než číslo!");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Něco je špatně --> {e.Message}");
                }

            } while (true);

            Console.WriteLine();
            Console.WriteLine("Děkujeme za použití naší služby.");
        }

    }
}

