using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class NthFrequency
    {
        public ArrayList findNthMostFrequency(int[] arr, int k)
        {
            SortedDictionary<int, int> nums = new SortedDictionary<int, int>();

            foreach (int num in arr)
            {
                if (nums.ContainsKey(num))
                    nums[num]++;
                else
                    nums.Add(num, 1);
            }
            
            // If n is greater than the number of unique elements in the array, return -1
            if (k > nums.Count)
                return new ArrayList();

            SortedDictionary<int, ArrayList> frequ = new SortedDictionary<int, ArrayList>();

            // Create a dictionary of frequencies
            foreach(KeyValuePair<int, int> n in nums)
            {
                if(frequ.ContainsKey(n.Value))
                    frequ[n.Value].Add(n.Key);
                else
                {
                    frequ.Add(n.Value, new ArrayList());
                    frequ[n.Value].Add(n.Key);
                }
            }

            //since the frequencies are sorted in ascending order, we can get the nth most frequency by approaching from the end
            k = frequ.Count - k;

            foreach(KeyValuePair<int, ArrayList> fr in frequ)
            {
                if(k == 0)
                    return fr.Value;
                k--;
            }
            return new ArrayList();
        }
    }
}
