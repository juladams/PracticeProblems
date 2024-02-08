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
            int sum = 1;
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
        
        public int[] productExceptSelf2(int[] nums)
        {
            if(nums.Length == 0)
                return new int[0];
            if (nums.Length == 1)
                return nums;

            int[] result = new int[nums.Length];
            //Initialize the result array to 1
            result[0] = 1;

            //Start from the left and multply the previous result by the previous number
            for(int i = 1; i < nums.Length; i++)
                result[i] = result[i - 1] * nums[i - 1];

            int rightSum = 1;
            //Start from the right and multiply the current result[] by the previous sun
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= rightSum;
                //Update the right sum by multiplying the previous right sum by the current number[]
                rightSum *= nums[i];
            }

            return result;
        }
    }
}
