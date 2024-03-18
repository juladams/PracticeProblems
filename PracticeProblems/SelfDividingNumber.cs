using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SelfDividingNumber
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (isSelfDividing(i))
                    result.Add(i);
            }

            return result;
        }
        
        public bool isSelfDividing(int num)
        {
            int temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit == 0 || num % digit != 0)
                    return false;
                temp /= 10;
            }
            return true;
        }
    }
}
