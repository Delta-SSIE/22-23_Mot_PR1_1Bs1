using System;

namespace hodnoty_pod_limitem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { -1.3, 2.2, 1.5, 1.4, 2.7 };
            Console.WriteLine(PodLimitem(cisla, 1.5)); //vypíše -1.3 a 1.4 
            Console.WriteLine(PodLimitem(cisla, 1.6)); //vypíše -1.3 , 1.5 a 1.4

        }

        static string PodLimitem(double[] pole, double limit)
        {
            string text = "";
            foreach (double x in pole)
            {
                if(x < limit)
                {
                    text = text + x.ToString() + " ";
                }
            }

            return text;
        }
    }
}
