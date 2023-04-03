using System;

namespace _09_Ukolrep_vypisdeti_vypiszeny
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            // nyní připravíme pole osob
            Person[] friends = new Person[]
            {
                new Person {
                    Name = "Thomas",
                    Surname = "Carter",
                    Age = 17,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lillian",
                    Surname = "Carter",
                    Age = 19,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Jim",
                    Surname = "Pearson",
                    Age = 54,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lou",
                    Surname = "Lacey",
                    Age = 36,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Minnie",
                    Surname = "Stanfords",
                    Age = 84,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Quincy",
                    Surname = "Dean",
                    Age = 12,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Steve",
                    Surname = "Blake",
                    Age = 61,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Andrew",
                    Surname = "Holmes",
                    Age = 33,
                    Sex = SexType.Male
                }
            };
            FindKids(friends);
            FindWomen(friends);

        }
        public static void FindKids(Person[] list)
        {
            foreach(Person x in list)
            {
                if(x.Age < 18)
                {
                    Console.WriteLine(x.IntroduceSelf());
                }
            }
        }

        public static void FindWomen(Person[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Sex == SexType.Female)
                {
                    Console.WriteLine(list[i].IntroduceSelf());
                }
            }
        }
    }
}
