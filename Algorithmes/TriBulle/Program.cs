using System;

namespace AlgorithmeTri
{
    class AlgoTriBulle
    {
        static int[] table;
        static void AfficherTable()
        {
            int n = table.Length - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(table[i] + " , ");
            }
            Console.WriteLine();
        }
        static void InitTable()
        {
            int[] tableau = { 1, 0, 5, 3, 8, 2, 6, 7, 9, 4 };
            table = tableau;
        }
        static void Main(string[] args)
        {
            InitTable();
            Console.WriteLine("Tableau initial :");
            
            AfficherTable();
            
            TriBulle();
            Console.WriteLine("Tableau une fois trié :");
            
            AfficherTable();
            Console.Read();
        }
        static void TriBulle()
        {
            int n = table.Length - 1;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (table[j - 1] > table[j])
                    {
                        int temp = table[j - 1];
                        table[j - 1] = table[j];
                        table[j] = temp;
                    }
                }
            }
        }
    }
}
