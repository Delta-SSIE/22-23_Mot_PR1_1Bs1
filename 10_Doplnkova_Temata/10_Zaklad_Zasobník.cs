namespace Zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zakaznici = { "Jan", "Libor", "Dalibor", "Pavel" };
            //Vytvoření zásobníku s obsahem z pole
            Stack<string> uzivatele = new Stack<string>(zakaznici);

            //Výpis ze zásobníku
            foreach (string uzi in uzivatele)
            {
                Console.WriteLine(uzi);
            }

            //Výpis prvního členu
            Console.WriteLine(uzivatele.Peek());

            //Vložení nového prvku do zásobníku
            uzivatele.Push("Jakub");
            uzivatele.Push("Hynek");
            foreach (string uzi in uzivatele)
            {
                Console.WriteLine(uzi);
            }

            //Odstranění prvku ze zásobníku
            uzivatele.Pop();
            uzivatele.Pop();
            uzivatele.Pop();
            uzivatele.Pop();
            Console.WriteLine(uzivatele.Peek());

        }
    }
}