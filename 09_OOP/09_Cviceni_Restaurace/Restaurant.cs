using System;
using System.Collections.Generic;
using System.Text;

namespace cvic_res
{
    internal class Restaurant
    {
        public string name;
        public Food[] foodlist;

        //Konstruktor třídy Restaurant
        public Restaurant(string nazev)
        {
            name = nazev;
            foodlist = new Food[] {
            new Food("Jehněčí",160,"Masové"),
            new Food("Kuřecí",100,"Masové"),
            new Food("Hovězí",120,"Masové"),
            new Food("Lilek",100,"Vegetarianské"),
            new Food("Tofu",120,"Veganské"),
            new Food("Kotleta",180,"Masové"),
            new Food("Brokolice",80,"Vegetarianské"),
            new Food("Květák",130,"Vegetarianské"),
            new Food("Seitan",150,"Veganské")
            };
        }

        //metoda pro výpis jídla z foodlistu
        public void VypisJidlo()
        {
            foreach (Food a in foodlist)
            {
                if (a.name != "X")
                {
                    Console.WriteLine($"{a.name} stojí {a.price} korun a jedná se o {a.type} jídlo.");
                }
            }
        }

        //metoda pro výpis jídla s podmínkami uživatele z foodlistu
        public void VypisJidlo2()
        {
            int penize = 0;
            //Počet peněz, zjištění.
            Console.WriteLine("Kolik máte peněz?");
            try
            {
                penize = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Nezadal jste číslo!");
            }
            //Zjištuji jaký typ jídla bude jíst.
            Console.WriteLine("Jste vegetarián, vegan, či jíte vše? (Zadejte Vegan/Vege/Vse)");
            string volba = Console.ReadLine();
            try
            {
                if (volba == "Vegan")
                {
                    volba = "Veganské";
                }
                if (volba == "Vege")
                {
                    volba = "Vegetarianské";
                }
                if (volba == "Vse")
                {
                    volba = "Vse";
                }
            } catch
            {
                Console.WriteLine("Zadal jste neplatný vstup");
            }
            //průchod polem a řešení, jestli se má daná položka vypsat.
            foreach (Food a in foodlist)
            {
                if (a.name != "X")
                {
                    if (a.price <= penize)
                    {
                        //Vypisuje se pokud type je stejný jako volba
                        if (a.type == volba)
                        {
                            Console.WriteLine($"{a.name} stojí {a.price} korun a jedná se o {a.type} jídlo.");
                        }
                        //Pokud je volba "Vegetarinské" pak se ještě řeší, aby se vypsalo i vegenaské jídlo.
                        if (volba == "Vegetarianské")
                        {
                            if (a.type == "Veganské")
                            {
                                Console.WriteLine($"{a.name} stojí {a.price} korun a jedná se o {a.type} jídlo.");
                            }
                        }
                        //Pokud jí vše, tak se vypisuje všechno!
                        if (volba == "Vse")
                        {
                            Console.WriteLine($"{a.name} stojí {a.price} korun a jedná se o {a.type} jídlo.");
                        }
                    }
                }

            }
        }
        //Metoda třídy Restaurant
        public void PridejJidlo()
        {
            int cena = 0;
            //Dotaz na název jídla
            Console.WriteLine("Jak se má nové jídlo jmenovat?");
            string nazev = Console.ReadLine();
            //Dotaz na cenu a odchycení chyby pomocí try
            Console.WriteLine("Jakou má mít jídlo cenu?");
            try
            {
                cena = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Nezadal jsi číslo!");
            }
            //Dotaz na typ a odchycení chyby pomocí try
            Console.WriteLine("O jaké jídlo se jedná vegetarináské, veganské, či masové? (Zadejte Vegan/Vege/Maso)");
            string volba = Console.ReadLine();
            try
            {
                if (volba == "Vegan")
                {
                    volba = "Veganské";
                }
                if (volba == "Vege")
                {
                    volba = "Vegetarianské";
                }
                if (volba == "Maso")
                {
                    volba = "Masové";
                }
            } catch
            {
                Console.WriteLine("Zadal jste neplatný vstup");
            }
            //Zvětšení pole foodlist o 1
            Array.Resize(ref foodlist, foodlist.Length + 1); 
            //Vložení nového jídla na nově vytvořený index
            foodlist[foodlist.Length - 1] = new Food(nazev, cena, volba); 
        }

        //Metoda třídy Restaurant
        public void OdeberJidlo()
        {
            //Dotaz na název jídla
            Console.WriteLine("Napiš název jídla, které chceš odebrat");
            string jidlo = Console.ReadLine();
            int kontrola = 0;
            //Průchod pole foodlist a hledání objektu s jménem, které zadal uživatel.
            foreach (Food x in foodlist)
            {
                if (jidlo == x.name)
                {
                    x.name = "X";
                    kontrola = 1;
                }
            }
            //Pokud nebylo nalazeno žádné jídlo, tak se vypíše.
            if (kontrola == 0)
            {
                Console.WriteLine("Zadaná jídlo není na seznamu");
            }
        }
        //Metoda třídy Restaurant, která přijmá 2 argumenty (dvě pole)
        public void JidelnicekUcastniku(string[] ucastnici, int[] penize)
        {
            //Vnější cyklus, prochází pole účastníci
            for (int i = 0; i < ucastnici.Length; i++)
            {
                //Vypíše jméno účastníka
                Console.WriteLine(ucastnici[i]);
                //Vnitřní cyklus, který prochází pole objektů foodlist
                foreach (Food a in foodlist)
                {
                    //Kontrola, aby se nevypsali "smazaná" jídla
                    if (a.name != "X")
                    {
                        //Kontrola jestli má účastník na dané jídlo peníze
                        if (a.price <= penize[i])
                        {
                            Console.WriteLine(a.name);
                        }
                    }
                }
                //Zalomení řádku na konci každého výpisu účastníka
                Console.WriteLine();

            }
        }
    }
}
