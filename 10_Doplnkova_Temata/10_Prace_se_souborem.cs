namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření souborů
            File.Create("Text.txt");

            //Vytvoř soubor a zapiš
            File.WriteAllText("Text2.txt", "Hello Worĺd!");

            //Čtení ze souboru
            Console.WriteLine(File.ReadAllText("Text2.txt"));

            //Smazání soubor
            File.Delete("Text2.txt");

        }
    }
}