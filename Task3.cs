using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task3
    {
        static int notContains(int[] array)
        {
            int ptr = 0;
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == 1)
                {
                    ptr = 1;
                    break;
                }
            }
            if (ptr == 0)
                return 1;

            for (int i = 0; i < n; i++)
                if (array[i] <= 0 || array[i] > n)
                    array[i] = 1;

            for (int i = 0; i < n; i++)
                array[(array[i] - 1) % n] += n;

            for (int i = 0; i < n; i++)
                if (array[i] <= n)
                    return i + 1;

            return n + 1;
        }
        
        public static void TaskThree()
        {
            Console.WriteLine("Task 3: We have some arry of ints ,we will find smalest number which isn't in array ");
            int[] a = { 9, 6, 4, 7, 2,0,-3,-8,8,14,1};
            Console.WriteLine("our array is :");
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" {0} ",a[i]);
            }
            Console.WriteLine("]");Console.WriteLine();
            Console.WriteLine("array not contains {0}",notContains(a));
        }
    }   
}
