using System;

namespace AlgorithmeTri
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int len = 9;

            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            
            Console.WriteLine("Tableau initial :");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Tableau une fois trié :");
            
            SortMethod(numbers, 0, len - 1);

            for (int i = 0; i < 9; i++) { 
                Console.WriteLine(numbers[i]);
            }

            Console.Read();

        }
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }

        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            
            left_end = (mid - 1);
            
            tmp_pos = left;
            
            num_elements = (right - left + 1);
            
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[tmp_pos++] = numbers[left++];
                }
                else
                {
                    temp[tmp_pos++] = numbers[mid++];
                }
            }

            while (left <= left_end) { 
                temp[tmp_pos++] = numbers[left++];
            }

            while (mid <= right) { 
                temp[tmp_pos++] = numbers[mid++];
            }

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}