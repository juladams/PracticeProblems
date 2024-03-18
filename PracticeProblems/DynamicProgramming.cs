using System;
using System.Collections.Generic;
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
            else
                memo.Add(n, (getSteps(memo, n - 1) + getSteps(memo, n - 2)));

            return memo[n];
        }
    }
}
