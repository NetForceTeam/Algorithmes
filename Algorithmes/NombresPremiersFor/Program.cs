using System;

namespace AlgorithmesDeCalcul
{
    class NombresPremiersFor
    {
        static void Main(string[] args)
        {
            int divis, nbr, n, compt = 0;
            bool Est_premier;

            Console.Write("Combien de nombres premiers : ");
            
            n = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(2);

            //-- primalité uniquement des nombres impairs
            for (nbr = 3; compt < n - 1; nbr += 2)
            {
                Est_premier = true;
                for (divis = 2; divis <= nbr / 2; divis++)
                    if (nbr % divis == 0)
                    {
                        Est_premier = false;
                        break;
                    }
                if (Est_premier)
                {
                    compt++;
                    Console.WriteLine(nbr);
                }
            }
            Console.ReadLine();
        }
    }
}