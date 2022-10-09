namespace znamkovac_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik procent žák získal? ");
            int znamka = int.Parse(Console.ReadLine());

            switch (znamka)
            {
                case >= 101:
                    Console.WriteLine("Zadaná procenta nedávají smysl");
                    break;
                case >= 83:
                    Console.WriteLine("Má výbornou");
                    break;
                case >= 67:
                    Console.WriteLine("Má chvalitebnou");
                    break;
                case >= 50:
                    Console.WriteLine("Má dobrou");
                    break;
                case >= 33:
                    Console.WriteLine("Má Dostatečnou");
                    break;
                default:
                    Console.WriteLine("Má Nedostatečnou");
                    break;
            }
            }
    }
}