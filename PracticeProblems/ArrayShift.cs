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

            int shift = k > nums.Length ? nums.Length - (k % nums.Length) : nums.Length - k;

            if (shift > 0 && nums.Length > 1 && k > 0)
            {
                int offset = shift;
                int i = 0;

                /*if (ar.Length % 2 == 0)
                {*/
                    while (i < nums.Length)
                    {
                        int temp = nums[i];
                        nums[i++] = nums[offset];
                        nums[offset] = temp;

                        offset = offset == nums.Length - 1 ? shift : offset + 1; // fix this line
                    }
                //}
                /*else
                {
                    int odd = ar[offset-1];

                    while (i < ar.Length/2)
                    {
                        int temp = ar[i];
                        ar[i++] = ar[offset];
                        ar[offset-1] = temp;

                        offset ++;
                    }

                    ar[^1] = odd;
                }*/
            }

            Console.WriteLine("Shifted Array");
            Array.ForEach(nums, n => Console.WriteLine(n));
        }
    }
}
