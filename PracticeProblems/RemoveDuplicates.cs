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

            //This is a simple solution that uses a foreach loop to iterate through the array
            //If the current element is not equal to the element at the count index, then we increment count and set the element at the count index to the current element
            //This way, we are able to remove duplicates and keep track of the number of unique elements
            //The time complexity of this solution is O(n) where n is the number of elements in the array
            //The space complexity of this solution is O(1) since we are not using any additional data structures
            //Example: [1,1,2,2,3,3,4,4,5,5] => [1,2,3,4,5]
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

