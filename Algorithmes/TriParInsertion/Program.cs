using System;

namespace AlgorithmeTri
{
    class TriParInsertion
    {
        static int[] table;

        /* Tri avec sentinelle :
        * dans la cellule de rang 0 se trouve une sentinelle (Int32.MinValue)
        * chargée d'éviter de tester dans la boucle tantque .. faire
        * si l'indice j n'est pas inférieur à 1, elle aura une valeur
        * inférieure à toute valeur possible de la liste.
        */

        static void AfficherTable()
        {
            int n = table.Length - 1;
            
            for (int i = 1; i <= n; i++) { 
                Console.Write(table[i] + " , ");
            }
            Console.WriteLine();
        }

        static void InitTable()
        {
            int[] tableau = { Int32.MinValue, 25, 7, 14, 26, 25, 53, 74, 99, 24, 98, 89 };
            table = tableau;
        }


        static void Main(string[] args)
        {
            InitTable();
            Console.WriteLine("Tableau initial :");
            
            AfficherTable();
            
            TriInsert();
            Console.WriteLine("Tableau une fois trié :");
            
            AfficherTable();
            Console.Read();
        }


        static void TriInsert()
        {
            int n = table.Length - 1;

            for (int i = 2; i <= n; i++)
            {
                int v = table[i];
                int j = i;

                while (table[j - 1] > v)
                {
                    table[j] = table[j - 1];
                    j = j - 1;
                }

                table[j] = v;

            }
        }
    }
}