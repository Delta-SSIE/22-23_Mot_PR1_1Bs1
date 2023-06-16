namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba listů
            List<Int16> seznamtelefonu = new List<Int16>(5);
            

            //Překlopení pole do listu
            string[] jmena = { "Honza", "Libor", "Janek" };
            List<string> seznampratel = new List<string>(jmena);
            
            //Přidávání do listu
            seznampratel.Add("Petra");
            seznampratel.Add("Karel");
            seznamtelefonu.Add(1);
            seznamtelefonu.Add(12);
            seznamtelefonu.Add(3);
            seznamtelefonu.Add(5);

            //Výpis z listu
            foreach (string a in seznampratel)
            {
                Console.WriteLine(a);
            }

            //Vypsaní jednoho prvku
            Console.WriteLine(seznampratel[0]);

            //Vypsaní kapacity a velikosti listu
            Console.WriteLine(seznampratel.Count);
            Console.WriteLine(seznampratel.Capacity);
            Console.WriteLine(seznamtelefonu.Capacity);

            //Vkladání na konkrétní index
            seznampratel.Insert(1, "Hynek");
            foreach (string a in seznampratel)
            {
                Console.WriteLine(a);
            }

            //Smazání prvků z listu
            seznampratel.Remove("Hynek");
            seznampratel.RemoveAt(0);
            seznampratel.RemoveRange(1, 2);
            foreach (string a in seznampratel)
            {
                Console.WriteLine(a);
            }
            seznampratel.Clear();

            //Hledání v listu (pokud prvek není v seznamu vypíše se -1
            int index = seznamtelefonu.IndexOf(150);
            Console.WriteLine(index);

            //List a jeho řazení

            foreach (int x in seznamtelefonu)
            {
                Console.WriteLine(x);
            }
            //řazení
            seznamtelefonu.Sort();
            foreach (int x in seznamtelefonu)
            {
                Console.WriteLine(x);
            }
            //řazení na opak
            seznamtelefonu.Reverse();
            foreach (int x in seznamtelefonu)
            {
                Console.WriteLine(x);
            }

        }
    }
}