using System;

namespace PracticeProblems
{
    internal class RemoveElement
    {
        public void removeElement(int[] nums, int val) 
        {
            int j = nums.Length - 1;
            int count = nums.Length;


            //Iterate through the array, when you find the value, swap it with the last value in the array
            //if the last value is the same as the value you are looking for or if j is <= i, decrement j
            //until you find a value that is not the same as the value you are looking for
            for(int i = 0;i < nums.Length; i++) 
            {
                if (nums[i] == val)
                {
                    count--;
                    if (j > i)
                    {
                        while (j > i)
                        {
                            if (nums[j] != val)
                            {
                                nums[i] = nums[j];
                                nums[j--] = int.MaxValue;
                                break;
                            }
                            j--;
                        }
                    }
                    else
                    {
                        nums[i] = int.MaxValue;
                    }
                }
            }
            Console.WriteLine("Count: " + count);

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
