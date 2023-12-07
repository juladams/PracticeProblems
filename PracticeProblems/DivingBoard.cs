using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class DivingBoard
    {
        public int boardLength(int s, int l, int k)
        {
            //number of possiblities if k is greater than 0
            int j = k;

            //Calculate the possible lengths
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(s * i + l * j--);
            }
            //((k+n-1)!)/((k!(n-1)!) = number of possiblities
            return k > 0 ? k + 1 : 0;
        }
    }
}
