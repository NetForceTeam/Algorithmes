using System;

namespace AlgorithmesDeCalcul
{
    class PgcdDeuxEntiersEuclide
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
                Console.WriteLine("Le pgcd n'existe pas !");
            }
            Console.ReadLine();
        }

        static int pgcd(int a, int b)
        {
            int r, t;
            if (b > a)
            {
                t = a;
                a = b;
                b = t;
            }
            do
            {
                r = a % b;
                a = b;
                b = r;
            } while (r != 0);
            return a;
        }
    }
}