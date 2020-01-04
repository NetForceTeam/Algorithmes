using System;

namespace AlgorithmesDeCalcul
{
    class NombresDeArmstrong
    {
        static void Main(string[] args)
        {
            
            int i, j, k, n, somcube;
            Console.WriteLine("Nombres de Armstrong :");

            for (i = 1; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    for (k = 0; k <= 9; k++)
                    {
                        n = 100 * i + 10 * j + k;
                        somcube = i * i * i + j * j * j + k * k * k;
                        if (somcube == n)
                        {
                            Console.WriteLine(n);
                        }
                    }
                }
            }

            Console.ReadLine();

        }
    }
}