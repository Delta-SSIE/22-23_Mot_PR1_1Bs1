using System;
using System.Collections.Generic;
using System.Text;

namespace Skolni_system
{
    internal class Kurz
    {
        public string nazev;
        public Student[] studenti = new Student[1000];
        public int PocetStudent = 0;

        public Kurz(string kurz)
        {
            nazev = kurz;
        }

        public void VypisStudenty()
        {
            foreach (Student a in studenti)
            {
                if (a != null)
                {
                    if (a.jmeno != "X")
                {
                   
                        Console.WriteLine(a.jmeno);
                    }
                }
            }
        }

        public void NovyStudent(string jmeno)
        {
            Student novystudent = new Student(jmeno);
            studenti[PocetStudent] = novystudent;
            PocetStudent++;
        }

        public void OdeberStudent(string student)
        {
            int nalez = 0;
            foreach (Student a in studenti)
            {
                if (a != null)
                {
                    if (a.jmeno != "X")
                {
                    
                        if(a.jmeno == student)
                        {
                            a.jmeno = "X";
                            nalez = 1;
                        }
                    }
                }
            }
            if (nalez == 0)
            {
                Console.WriteLine("Takový student není zapsán!");
                Console.ReadKey();
            }
        }
    }
}
