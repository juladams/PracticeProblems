using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace PracticeProblems
{
    public class Arrays2Pointers
    {
        //Given an array nums of 2n integers, create n pair such that the sum of min(ai, bi) for all i is maximized
        public int ArrayPairSum(int[] nums) 
        {
            Array.Sort(nums);
            int sum = 0;

            for(int i = 0; i < nums.Length; i+=2)
                sum += nums[i];

            return sum;
        }
        
        //Given an array of integers, find two numbers such that they add up to a specific target number.
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while(left < right && numbers[left] + numbers[right] != target)
            {
                if(numbers[left] + numbers[right] > target)
                    right--;
                else
                    left++;
            }

            return new int[] {left+1, right+1};
        }
        //Removes all occurances of val and returns the remaining count
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int  i = 0;
            int j = nums.Length - 1;

            while(i <= j)
            {
                if(nums[i] == val)
                {
                    if(nums[j] != val)
                    {
                        nums[i++] = nums[j];
                        nums[j--] = val;
                        count++;
                    }
                    else
                        j--;
                }
                else
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        //Given an array of 1s and 0s count the maximum number of consecutive 1s
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    int tmp = 1;
                    i++;

                    while(i < nums.Length && nums[i] == 1)
                    {
                        tmp++;
                        i++;
                    }

                    count = Math.Max(count, tmp);
                }
            }
            
            return count;
        }
        //Given an array of integers, find the shortest contiguous subarray which has the largest sum and return the sum
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int sum = 0;
            int count = int.MaxValue;

            //iterate through the array and add the elements to the sum until the sum is greater than or equal to the target
            //then subtract the left element from the sum and increment the left pointer
            //keep track of the minimum count          
            while(right < nums.Length)
            {
                sum += nums[right];

                while(sum >= target)
                {
                    count = Math.Min(count, right - left + 1);
                    sum -= nums[left++];
                }
                right++;
            }
            return count == int.MaxValue ? 0 : count;
        }

        //Given an array of integers, reverse the array by k elements
        public void Rotate(int[] nums, int k) 
        {
            //if k is greater than the length of the array, then set k to k % nums.Length
            k = k % nums.Length;

            //reverse the entire array
            Array.Reverse(nums);

            //reverse the first k elements
            Array.Reverse(nums, 0, k);

            //reverse the remaining elements
            Array.Reverse(nums, k, nums.Length - k);
        }


        public string ReverseWords(string s)
        {
            //Create a string array of the words, then print the words in reverse order
            //trim leading and trailing whitespaces
            s = s.Trim();

            List<string> res = new List<string>();

            //build the string array of words
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ' && i < s.Length)
                {
                    StringBuilder tmp = new StringBuilder();

                    while(i < s.Length && s[i] != ' ' )
                        tmp.Append(s[i++]);

                    res.Add(tmp.ToString());
                }
            }

            StringBuilder str = new StringBuilder();
            res.Reverse();

            string t = String.Join(' ', res);

            return t;
        }

        //Keep word order but reverse the letters in each word
        public string ReverseWords2(string s) 

        {
            List<string> res = new List<string>();

            //build the string array of words
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ' && i < s.Length)
                {
                    StringBuilder tmp = new StringBuilder();

                    while(i < s.Length && s[i] != ' ' )
                        tmp.Append(s[i++]);

                    res.Add(tmp.ToString());
                }
            }

            StringBuilder str = new StringBuilder();

            foreach(string word in res)
            {
                char[] tmp = word.ToCharArray();
                Array.Reverse(tmp);
                str.Append(new string(tmp) + ' ');
            }

            return str.ToString().Trim();
        }

        //Leetcode 18, Given an array nums of n integers and an integer target, are there elements 
        //a, b, c, and d in nums such that a + b + c + d = target?
       /*  public IList<IList<int>> FourSum(int[] nums, int target) 
        {
            if(nums.Length < 4)
                return new List<IList<int>>();
            
            //Ilist of Ilist to store the result
            IList<IList<int>> result = new List<IList<int>>();

            //sort the array
            Array.Sort(nums);

            //iterate through the array
            //use two pointers to find the sum of the two numbers that equal the target
            for(int i = 0; i < nums.Length - 3; i++)
            {
                //skip duplicates
                if(i > 0 && nums[i] == nums[i - 1])
                    continue;

                for(int j = i + 1;j < nums.Length - 2; j++)
                {
                    if(j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    
                    int left = j + 1;
                    int right = nums.Length - 1;

                    while(left < right)
                    {
                        long leftValue = nums[i];
                        long centerValue = nums[j];
                        long startValue = nums[left];
                        long endValue = nums[right];

                        long sum = leftValue + centerValue + startValue + endValue;

                        //if the sum is greater than the target decrease right pointer
                        //else increase left pointer
                        if(sum > target)
                            right--;
                        else if(sum < target)
                            left++;
                        else
                        {
                            result.Add(new List<int> {nums[i], nums[j], nums[left], nums[right]});
                            left++;
                            
                            while (nums[left] == nums[left - 1] && left < nums.Length - 1)
                                left++;
                        }
                    }

                }
                
            }


            return result;
        } */

    }

    
}