using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task4
    {
        static Boolean IsProperly(String sequence)
        {
            Stack<char> s = new Stack<char>();
           
            foreach (char st in sequence.ToCharArray())
            {
                if (st == '(' )
                {
                    s.Push(st);
                }
                else
                {
                    if (s.Count==0)
                    {
                        return false;
                    }
                    else
                    {
                        char top = (char)s.Peek();
                        if (st == ')' && top == '(')
                        {
                            s.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (s.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void TaskFour()
        {
            Console.WriteLine("Task4: input String sequence with brackets to find out it is valid or not. ");
            String sequence = Console.ReadLine();
            Console.WriteLine("{0} is {1} ",sequence, IsProperly(sequence));
        }
    }
}
