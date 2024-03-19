using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Exam
    {
        
        public int LocateEarliestMonth(List<int> stockPrice)
        {
            int month = 0;
            int left = 0;
            int right = 0;
            int change = int.MaxValue;

            //get the total sum of the stock price
            for(int i = 0; i < stockPrice.Count;i++)
                right += stockPrice[i];

            //iterate through the stock price and find the earliest month
            for (int i = 0; i < stockPrice.Count-1; i++)
            {
                left += stockPrice[i];
                right -= stockPrice[i];

                if (Math.Abs(left - right) < change)
                {
                    change = Math.Abs(left - right);
                    month = i + 1;
                }
            }
            return month;
        }

        public List<int> findKthMinimumVulnerbility(int k, int m, List<int> vulnerbility)
        {
            List<int> result = new List<int>();

            for(int i  = 0; i <= vulnerbility.Count - m; i++)
            {
                List<int> temp = vulnerbility.GetRange(i, m);
                temp.Sort();
                result.Add(temp[k-1]);
            }

            return result;

        }
        /*public int findKthMinimumVulnerbility2(int k, int m, List<int> vulnerbility)
        {
            List<int> result = new List<int>();



        }*/   
    }
}
