using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SumArray
    {
        public int[] productExceptSelf(int[] nums)
        {
            if(nums.Length == 0)
                return new int[0];
            if (nums.Length == 1)
                return nums;

            int[] result = new int[nums.Length];
            int sum = int.MaxValue;
            bool zero = false;
            int zeroCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && !zero)
                {
                    zero = true;
                    zeroCount = i;
                    continue;
                }
                else if(sum == int.MaxValue)
                    sum = nums[i];
                else
                    sum *= nums[i];
            }

            if (zero)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == zeroCount)
                        result[i] = sum;
                    else
                        result[i] = 0;
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                    result[i] = sum / nums[i];
            }
            return result;
        }
    }
}
