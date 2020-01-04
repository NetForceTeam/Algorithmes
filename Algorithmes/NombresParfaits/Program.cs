using System;

namespace AlgorithmesDeCalcul
{
    class NombresParfaits
    {
        static void Main(string[] args)
        {
            int compt = 0, n, k, somdiv, nbr;
            Console.Write("Entrez combien de nombre parfaits : ");

            n = Int32.Parse(Console.ReadLine());
            nbr = 2;

            while (compt != n)
            {
                somdiv = 1;
                k = 2;
                while (k <= nbr / 2)
                {
                    if (nbr % k == 0) somdiv += k;
                    k++;
                }
                if (somdiv == nbr)
                {
                    Console.WriteLine(nbr + " est un nombre parfait");
                    compt++;
                }
                nbr++;
            }
            Console.ReadLine();
        }
    }
}