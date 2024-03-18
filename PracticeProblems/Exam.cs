using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Exam
    {
        /*public int LocateEarliestMonth(List<int> stockPrice)
        {
            int month = 0;
            List<int>  left = new List<int>();
            left.Add(stockPrice[0]);
            List<int> right = new List<int>();
            right.Add(stockPrice[1]);

            for(int i = 1; i < stockPrice.Count-1;i++)
                left[i] = left[i-1] + stockPrice[i];
        }*/

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
