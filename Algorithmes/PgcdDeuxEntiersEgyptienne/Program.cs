using System;

namespace AlgorithmesDeCalcul
{
    class PgcdDeuxEntiersEgyptienne
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le premier nombre : ");
            int p = Int32.Parse(Console.ReadLine());

            Console.Write("Entrez le deuxième nombre : ");
            int q = Int32.Parse(Console.ReadLine());

            if (p * q != 0)
            {
                Console.WriteLine("Le pgcd de " + p + " et " + q + " est " + pgcd(p, q));
            }
            else
            {
                Console.WriteLine("Le pgcd n'existe pas");
            }
            Console.ReadLine();
        }

        static int pgcd(int p, int q)
        {
            while (p != q)
            {
                if (p > q) p -= q;
                else q -= p;
            }
            return p;
        }
    }
}