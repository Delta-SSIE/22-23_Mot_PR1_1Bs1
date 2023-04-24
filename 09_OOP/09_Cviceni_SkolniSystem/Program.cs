using System;

namespace Skolni_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, zadej jméno svého kurzu");
            string nazev = Console.ReadLine();

            Kurz mujkurz = new Kurz(nazev);

            mujkurz.NovyStudent("Jindřich");
            mujkurz.NovyStudent("Bedřich");
            mujkurz.NovyStudent("Lukáš");

            while(true)
            {
                Console.Clear();  
                Console.WriteLine("1 Vypis studnetů \n2 Přidání studenta \n3 Odeber studenta");
                int volba = int.Parse(Console.ReadLine());
                try
                {
                    if (volba == 1)
                    {
                        mujkurz.VypisStudenty();
                        Console.ReadKey();
                    }
                    if (volba == 2)
                    {
                        Console.WriteLine("Napiš jmeno studenta");
                        string name = Console.ReadLine();
                        mujkurz.NovyStudent(name);
                    }
                    if (volba == 3)
                    {
                        Console.WriteLine("Napiš jmeno studenta");
                        string name = Console.ReadLine();
                        mujkurz.OdeberStudent(name);
                    }

                } catch
                {
                    Console.WriteLine("Nevybral si jedinou možnost");
                }
                
            }
            
        }
    }
}
