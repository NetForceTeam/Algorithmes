using System;

namespace AlgorithmeTri
{
    public class TriDeShell
    {
        public static void Main()
        {
            int[] iArrary = new int[] { 1, 5, 3, 6, 10, 55, 9, 2, 87, 12, 34, 75, 33, 47 };
            
            ShellSorter sh = new ShellSorter();
            sh.Sort(iArrary);
            
            for (int m = 0; m <= 13; m++)
            {
                Console.WriteLine("{0}", iArrary[m]);
            }
            Console.ReadLine();
        }
    }


    class ShellSorter
    {
        public void Sort(int[] list)
        {
            int inc;
            
            for (inc = 1; inc <= list.Length / 9; inc = 3 * inc + 1) ;
            {
                for (; inc > 0; inc /= 3)
                {
                    for (int i = inc + 1; i <= list.Length; i += inc)
                    {
                        
                        int t = list[i - 1];
                        int j = i;
                        
                        while ((j > inc) && (list[j - inc - 1] > t))
                        {
                            list[j - 1] = list[j - inc - 1];
                            j -= inc;
                        }
                        
                        list[j - 1] = t;
                    }
                }
            }
        }
    }
}