namespace Slovnik_cz_ang
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, string> slovnik = new Dictionary<string, string>();
            while (true)
            {
                //Dotaz na termín a jeho překlad
                Console.Write("Napiš české slovo: ");
                string czslovo = Console.ReadLine();
                Console.Write("Napiš anglický překlad: ");
                string angslovo = Console.ReadLine();

                //Řešení, jestli dané slovo již ve slovníku není!
                if (slovnik.ContainsKey(czslovo)) {
                    Console.WriteLine("Dané slovo, již ve slovníku je. Chceš ho změnit?");
                    Console.WriteLine($"Verze stará {slovnik[czslovo]} a Nová verze: {angslovo}");
                    Console.WriteLine("Pokud chceš změnu napiš A, pokud ne, tak N");
                    string roz = Console.ReadLine();
                    if (roz == "A")
                    {
                        slovnik.Remove(czslovo);
                        slovnik.Add(czslovo, angslovo);
                    }
                } else
                {
                    slovnik.Add(czslovo, angslovo);
                }

                //Pro kontrolu výpis z slovníku
                foreach (KeyValuePair<string, string> slov in slovnik)
                {
                    Console.WriteLine($"{slov.Key} má překlad: {slov.Value}");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}