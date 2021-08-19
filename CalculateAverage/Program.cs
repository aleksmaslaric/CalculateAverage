using System;

namespace CalculateAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnos = "0";
            int i = 0;
            int skupno = 0;
            int trenutnoStevilo = 0;

            while (vnos != "-1")
            {
                Console.WriteLine("Zadnje število je bilo: {0}", trenutnoStevilo);
                Console.WriteLine("Prosim vnesite naslednjo oceno");
                Console.WriteLine("Trenutno stevilo vnosov: {0}", i);
                Console.WriteLine("Vnesite -1, ko želite izračun povprečja!");

                vnos = Console.ReadLine();
                if (vnos.Equals("-1"))
                {
                    Console.WriteLine("--------------------------");
                    double povprecje = (double)skupno / (double)i;
                    Console.WriteLine("Povprečje učenca je: {0}", povprecje);
                }
                if (int.TryParse(vnos, out trenutnoStevilo) && trenutnoStevilo > 0 && trenutnoStevilo < 21)
                {
                    skupno = skupno + trenutnoStevilo;
                    // lahko tudi skupno += trenutnoStevilo;
                } else
                {
                    if (!(vnos.Equals("-1")))
                    {
                        Console.WriteLine("Prosim vnesite število med 1 in 20");
                        continue;
                    }
                }

                i++; 
            }
            Console.Read();
        }
    }
}
