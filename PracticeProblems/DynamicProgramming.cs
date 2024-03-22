using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class DynamicProgramming
    {
        public int ClimbStairs(int n)
        {
            //base case
            if (n == 1)
                return 1;

            Dictionary<int, int> memo = new Dictionary<int, int>();
            memo.Add(1, 1);

            return getSteps(memo, n);
        }

        public int getSteps(Dictionary<int, int> memo, int n)
        {
            //base case
            if (n <= 2)
                return n;
            else if (memo.ContainsKey(n))
                return memo[n];
            //recursive case, calculate the number of steps for n - 1 and n - 2
            else
                memo.Add(n, (getSteps(memo, n - 1) + getSteps(memo, n - 2)));

            return memo[n];
        }

        //LeetCode 1641. Count Sorted Vowel Strings
        public int CountVowelStrings(int n)
        {
            if (n == 1)
                return 5;

            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { 1, 1, 1, 1, 1 });
            //u, o, i, e, a
            list.Add(new List<int> { 1, 2, 3, 4, 5 });

            for (int i = 2; i < n; i++)
            {
                List<int> temp = new List<int>();
                temp.Add(1);
                //u
                int sum = list[i - 1][0] + list[i - 1][1];
                temp.Add(sum);
                //o
                sum += list[i - 1][2];
                temp.Add(sum);
                //i
                sum += list[i - 1][3];
                temp.Add(sum);
                //e
                sum += list[i - 1][4];
                temp.Add(sum);
                //a
                sum += list[i - 1][4];

                list.Add(temp);
            }
            return list[n - 1].Sum();

        }

        public int CountVowelStrings2(int n)
        {
            //Combinations with repetition
            //(n + r - 1)! / r!(n - 1)! n = string length, r = number of vowels
            return (n + 1) * (n + 2) * (n + 3) * (n + 4) / 24;
        }

        public int CoinChange(int[] coins, int amount)
        {
            //base case
            if (amount == 0)
                return 0;
            //create a dp array to store the minimum number of coins needed to make the amount
            int[] memo = new int[amount + 1];
            memo[0] = 0;
            int max = amount + 1;

            //initialize the array to the max value
            for (int i = 1; i < memo.Length; i++)
                memo[i] = max;

            //iterate through the coins and the amount
            for(int i = 0; i < coins.Length; i++)
            {
                for(int j = coins[i]; j <= amount; j++)
                {
                    //update the memo array with the minimum number of coins needed to make the amount
                    memo[j] = Math.Min(memo[j], memo[j - coins[i]] + 1);
                }
            }
            //return the minimum number of coins needed to make the amount
            return memo[amount] == max ? -1 : memo[amount];
        }
    }
}
