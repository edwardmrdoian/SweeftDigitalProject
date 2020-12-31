using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftDigitalProject
{
    class Task2
    {
        static int MinSplit(int amount)
        {
            int[] coins = { 1, 5, 10, 20, 50 };
            int remains, coinsAmount, allcoins;
            int i = 1;
            remains = amount % coins[coins.Length - i];
            coinsAmount = amount / coins[coins.Length - i];
            allcoins = coinsAmount;
            Console.WriteLine("{0} {1} tetri ", coinsAmount, coins[coins.Length - i]);
            i++;
            for (int l = 5; l != i; l--)
            {
                int b = remains;
                remains %= (coins[coins.Length - i]);
                coinsAmount = b / (coins[coins.Length - i]);
                allcoins += coinsAmount;
                Console.WriteLine("{0} {1} tetri ", coinsAmount, coins[coins.Length - i]);
                if (i == 5) break;
                i++;
            }
            Console.Write("amount of all coins: ");
            return allcoins;
        }
        public static void TaskTwo()
        {
            Console.WriteLine("Task2: Enter amount in tetri ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Answer: {0}", MinSplit(amount));
        }
    }
}
