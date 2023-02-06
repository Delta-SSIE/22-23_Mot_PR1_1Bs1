using System;

namespace Je_v_norme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
            Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
            Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true

            Console.WriteLine(JeVNorme(2.5, 1.3, 0.7));
        }

        static bool JeVNorme(double rozmer, double mustr, double tolerance)
        {
            //Musí se ohlídat, že vytvořený rozměr je mezi spodní a horní hranicí tolerance.
            //Musí být menší než mustr+tolerance (u prvního volání 33+3.5 = 36.5)
            //Zároveň musí být větší než mustr-tolerance (u prvního volání 33-3.5 = 29.5)
            if (rozmer < mustr+tolerance && rozmer > mustr-tolerance)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
