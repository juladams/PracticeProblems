using System;

namespace PracticeProblems
{
    public class ArrayShift
    {

        public void shiftRight(int[] nums, int k)
        {
            Console.WriteLine("Original Array");
            Array.ForEach(nums, n => Console.WriteLine(n));

            int shift = k > nums.Length ? nums.Length - (k % nums.Length) : nums.Length - k;

            if (shift > 0 && nums.Length > 1 && k > 0)
            {
                int i = shift;
                int[] ar2 = new int[nums.Length];
                Array.Copy(nums, ar2 , ar2.Length);
                int j = 0;

                while(j < ar2.Length)
                {
                    nums[j++] = ar2[i];
                    
                    i = i == nums.Length - 1 ? 0 : i + 1;
                }

                Console.WriteLine("Shifted Array");
                Array.ForEach(nums, n => Console.WriteLine(n));
            }

        }
        
        public void shiftArray2(int[] nums, int k)
        {
            Console.WriteLine("Original Array");
            Array.ForEach(nums, n => Console.WriteLine(n));

            int shift = k > nums.Length ? k % nums.Length : k;

            if (shift > 0 && nums.Length > 1)
            {
                int jump = shift;
                int hold = nums[0];
                int count = nums.Length;

                //fix this
                while (count > 0)
                {
                    int tmp = nums[jump]; 
                    nums[jump] = hold;
                    hold = tmp;

                    jump = jump + shift > nums.Length - 1 ? shift - (nums.Length - jump - 1) - 1 : jump + shift; // fix this line
                    count--;
                }
            }

            Console.WriteLine("Shifted Array");
            Array.ForEach(nums, n => Console.WriteLine(n));
        }
    }
}
