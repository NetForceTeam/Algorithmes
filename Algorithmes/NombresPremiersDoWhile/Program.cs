using System;

namespace AlgorithmesDeCalcul
{
    class NombresPremiersDoWhile
    {

        static void Main(string[] args)
        {

            int divis, nbr, n, compt = 0;
            bool Est_premier;
            
            Console.Write("Combien de nombres premiers : ");
            n = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(2);
            nbr = 3;
            
            while (compt < n - 1)
            {
                divis = 2;
                Est_premier = true;
                do
                {
                    if (nbr % divis == 0) Est_premier = false;
                    else divis = divis + 1;
                }
                while ((divis <= nbr / 2) && (Est_premier == true));
                    if (Est_premier)
                    {
                        compt++;
                        Console.WriteLine(nbr);
                    }
                nbr++;
            }
            Console.ReadLine();
        }

    }
}