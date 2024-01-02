using System;

namespace PracticeProblems
{
    internal class RemoveDuplicates
	{
        public int removeDuplicates(int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;

            int count = 0;

            foreach (var item in nums)
            {
                if (nums[count] != item)
                {
                    nums[++count] = item;
                }

            }
/*
            for(int i = 0; i <= count; i++)
            {
                Console.WriteLine(nums[i]);
            }*/

            return count+1;
        }
    }
}   

