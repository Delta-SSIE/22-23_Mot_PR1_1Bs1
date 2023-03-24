using System;

namespace trida_objekt_zaklad
{
    //Nová třída s vlastností barva
    class Car
    {
        string znacka = "Toyota";
        //Definuje se až když se tvoří objekt
        string barva;
        public void Jed()
        {
            Console.WriteLine("Brrr brrr brrrm!");
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Vytvoření nového objektu a zavolání jeho vlastnosti "znacka"
                Car mojeauto = new Car();
                Console.WriteLine(mojeauto.znacka);
                //Vytvoření nového objektu a zavolání jeho vlastnosti "znacka"
                Car sousedovoauto = new Car();
                Console.WriteLine(sousedovoauto.znacka);

                //Využívání třídy z jiného souboru "Class1.cs"
                Plane mojeletadlo = new Plane();
                Console.WriteLine(mojeletadlo.color);
                Console.WriteLine(mojeletadlo.motor);

                //Metody volané objekty
                mojeletadlo.Letani();
                sousedovoauto.Jed();
                mojeauto.Jed();

                //Definice field (vlastnosti) u daného objektu
                mojeauto.barva = "zelená";
                sousedovoauto.barva = "modrá";
                Console.WriteLine($"Moje auto je značky {mojeauto.znacka} a má barvu {mojeauto.barva}");
                Console.WriteLine($"Sesedovo auto je značky {sousedovoauto.znacka} a má barvu {sousedovoauto.barva}");

                //Lze u objektu přepsat vlastnost
                mojeauto.znacka = "Volvo";
                Console.WriteLine($"Moje auto je značky {mojeauto.znacka} a má barvu {mojeauto.barva}");

            }
        }
    }
    
   
}
