using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task5
    {
        static int countVariants(int stearsCount)
        {
            int variant1, variant2, bothvariants1, bothvariants2, all;
            int Variant;
            all = 1;
            variant1 = stearsCount / 2;
            Variant = stearsCount % 2;
            variant2 = Variant;
            bothvariants1 = variant1 + variant2;
            Console.WriteLine("Variant {0}", all);
            Console.WriteLine("{0} - 2 Steps and {1} - 1 step", variant1, variant2);
            Console.WriteLine("we will need to pass  {0} steps", bothvariants1);
            Console.WriteLine();
            all++;
            for (int n = 0; n < bothvariants1; n++)
            {
                variant1 -= 1;
                variant2 += 2;
                bothvariants2 = variant1 + variant2;

                if (variant1 < 0) { break; }

                Console.WriteLine("Variant {0}", all);
                Console.WriteLine("{0} - 2 Steps and {1} - 1 step", variant1, variant2);
                Console.WriteLine("we will need to pass  {0} steps", bothvariants2);
                Console.WriteLine();
                all++;

            }
            Console.WriteLine("At all {0} Variants !!!", all - 1);
            return stearsCount;
        }
        public static void TaskFive()
        {
            Console.WriteLine("Task 5: enter number of stairs.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(countVariants(num));
        }
    }
}
