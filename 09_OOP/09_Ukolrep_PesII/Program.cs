using System;

namespace Pes_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pes lord = new Pes();
            try
            {
                lord.Jmeno = "Lord";
                lord.Nohy = 4;
                lord.JeOckovany = true;
                Console.WriteLine(lord.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }


            try
            {
                Pes podvratak = new Pes();
                podvratak.Jmeno = "Vořech";
                podvratak.Nohy = 4;
                podvratak.JeOckovany = false;
                Console.WriteLine(podvratak.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }


            try
            {
                Pes mutant = new Pes();
                mutant.Jmeno = "Mutantík";
                mutant.Nohy = 5;
                mutant.JeOckovany = false;
                Console.WriteLine(mutant.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }


            try
            {
                Pes slechtic = new Pes();
                slechtic.Jmeno = "Juan Ricardo Esteban Rodriquez de La Santorini";
                slechtic.Nohy = 3;
                slechtic.JeOckovany = false;
                Console.WriteLine(slechtic.PredstavSe());
            }
            catch (Exception e)
            {
                Console.WriteLine("Byla vložena neplatná hodnota ({0})", e.Message);
            }

        }
    }
}
