namespace List_Nasobky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Nasobky(90, 100)));
            //mělo by vypsat 92, 93, 94, 98, 99, 100

            Console.WriteLine(String.Join(", ", Nasobky(10000, 10010)));
            //mělo by vypsat 10000, 10004, 10005, 10006, 10010
        }

        static int[] Nasobky (int min, int max)
        {
            //Vytvoření listu pro int
            List<Int32> nasobky = new List<Int32>();
            
            //cyklus, který prochází čísla od min do maxu
            for (int i = min; i <= max; i++)
            {
                //podmínka, jestli jsou čísla dělitelná 2 a 3 (zároveň negace, pokud jsou děleni oběma)
                if ((i % 2 == 0 || i % 3 == 0) && !(i % 2 == 0 && i % 3 == 0))
                {
                    nasobky.Add(i);
                }
            }

            //vrací list, který se převede na pole!
            return nasobky.ToArray();
            
        }
    }
}