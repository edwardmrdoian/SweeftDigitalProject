using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task1
    {
         static Boolean IsPalindrome(string text)
        {
            string reverseText;
            char[] givenText = text.ToCharArray();
            Array.Reverse(givenText);
            reverseText = new string(givenText);
            bool palindrome = text.Equals(reverseText, StringComparison.OrdinalIgnoreCase);
            if (palindrome == true) return true;
            else return false;
        }
        public static void TaskOne()
        {
            Console.WriteLine("task 1: Enter the word to find out if it is palindrome.");
            string palindromeText = Console.ReadLine();
            bool answer = Task1.IsPalindrome(palindromeText);
            if (answer == true)
            {
                Console.WriteLine("{0} is Palindrome ", palindromeText);
            }
            else
            {
                Console.WriteLine("{0} is not Palindrome ", palindromeText);
            }

        }
    }
}
