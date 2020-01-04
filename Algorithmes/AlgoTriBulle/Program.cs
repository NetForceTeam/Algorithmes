﻿using System;

namespace Algorithme
{
    class TriBulle
    {
        static int[] table;
        static void AfficherTable()
        {
            int n = table.Length - 1;
            for (int i = 1; i <= n; i++)
            {
                System.Console.Write(table[i] + " , ");
            }
            System.Console.WriteLine();
        }
        static void InitTable()
        {
            int[] tableau = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            table = tableau;
        }
        static void Main(string[] args)
        {
            InitTable();
            System.Console.WriteLine("Tableau initial :");
            AfficherTable();
            TriBulle();
            System.Console.WriteLine("Tableau une fois trié :");
            AfficherTable();
            System.Console.Read();
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
