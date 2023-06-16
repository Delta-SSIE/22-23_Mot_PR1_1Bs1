namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = NactiCisla();
            Console.WriteLine("Byla vložena čísla: " + String.Join(", ", cisla));
        }

        static int[] NactiCisla()
        {
            int cislo;
            List<Int32> cisla = new List<Int32>();
            while (true)
            {
                Console.Write("Napiš jedno čislo (celočiselné): ");
                try
                {
                    cislo = int.Parse(Console.ReadLine());
                    cisla.Add(cislo);
                }
                catch
                {
                    if (Console.ReadLine() == "q" || Console.ReadLine() == "Q")
                    {
                        break;
                    }
                    Console.WriteLine("Chtěl jsem číslo!");
                    Console.ReadKey();
                }
            }
            return cisla.ToArray();
        }
    }
}