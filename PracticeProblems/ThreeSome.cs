using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ThreeSome
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            HashSet<List<int>> d = new HashSet<List<int>>();
            Array.Sort(nums);

            int start = 0;
            int left = 1;
            int right = nums.Length - 1;
            int sum = 0;

            while(start < nums.Length - 2 && nums[start] < 1)
            {
                while (left < right)
                {
                    sum = nums[start] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        List<int> temp = new List<int> { nums[start], nums[left], nums[right] };

                        if (!d.Contains(temp))
                        {
                            d.Add(temp);
                            result.Add(temp);

                            //logic to elemenate dubs
                            while (left + 1 < right && nums[left] == nums[left + 1])
                                left++;

                            left++;
                            right--;
                        }
                    }
                    //if the sum is greater than 0, move the right pointer to the left
                    else if (sum > 0)
                        right--;
                    //if the sum is less than 0, move the left pointer to the right
                    else
                        left++;
                }
                //logic to elemenate dubs
                while(start + 1 < nums.Length - 2 && nums[start] == nums[start + 1])
                    start++;
                start++;
                left = start + 1;
                right = nums.Length - 1;               
            }

            return result;

        }

    }
}
