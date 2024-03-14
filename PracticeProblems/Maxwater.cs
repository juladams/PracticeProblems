using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Maxwater
    {
        public int maxArea(int[] height)
        {
            int max = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                if (Math.Min(height[left], height[right]) * (right - left) > max)
                    max = Math.Min(height[left], height[right]) * (right - left);
                
                if (height[left] < height[right])
                    left++;
                else
                    right--;

            }
            return max;
        }
    }
}
