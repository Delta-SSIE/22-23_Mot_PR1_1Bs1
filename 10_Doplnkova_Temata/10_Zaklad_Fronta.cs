namespace Fronta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zakaznici = { "Jan", "Libor", "Dalibor", "Pavel" };
            //založení fronty s obsahem z pole stringu
            Queue<string> nabanany = new Queue<string>(zakaznici);

            //Výpis z fronty
            foreach (string zak in nabanany)
            {
                Console.WriteLine(zak); 
            }

            //Velikost fronty
            Console.WriteLine(nabanany.Count());

            //Přidání prvku
            nabanany.Enqueue("Zbyněk");
            foreach (string zak in nabanany)
            {
                Console.WriteLine(zak);
            }

            //Odebrání z fronty
            nabanany.Dequeue();
            nabanany.Dequeue();
            foreach (string zak in nabanany)
            {
                Console.WriteLine(zak);
            }

            //Obsahuje fronta prvek?
            Console.WriteLine(nabanany.Contains("Zbyněk"));

            //Kdo je vepředu fronty
            Console.WriteLine(nabanany.Peek());
            nabanany.Dequeue();
            Console.WriteLine(nabanany.Peek());
        }
    }
}