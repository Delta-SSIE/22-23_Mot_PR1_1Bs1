namespace Slovník
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Založení slovníku
            Dictionary<int,string> ubytovani = new Dictionary<int, string>();
            
            //Vkládání prvků do slovníku
            ubytovani.Add(5, "Jakub Horák");
            ubytovani.Add(1, "Milada Garážová");
            ubytovani.Add(12, "Františka Vácalová");

            //Výpis ze slovníku
            foreach (KeyValuePair<int,string> zakazník in ubytovani)
            {
                Console.WriteLine($"Na pokoji číslo {zakazník.Key} je ubytovaný zákazník jménem {zakazník.Value}");
            }

            //Vytažení informace ze slovníku podle klíče
            Console.WriteLine(ubytovani[12]);
            Console.WriteLine(ubytovani[1]);

            //Odebrání ze slovníku dle klíče
            ubytovani.Remove(12);
            foreach (KeyValuePair<int, string> zakazník in ubytovani)
            {
                Console.WriteLine($"Na pokoji číslo {zakazník.Key} je ubytovaný zákazník jménem {zakazník.Value}");
            }
        }
    }
}