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
                Console.WriteLine("There are a total of {0} short boards of size {1} and {2} long boards of " +
                    "size {3} for a total size of {4}", i, s, j, l, (s*i + l*j--));
            }
            //((k+n-1)!)/((k!(n-1)!) = number of possiblities
            return k > 0 ? k + 1 : 0;
        }

        //assuming the boards are different lengths
        public int boardLength2(int[] boardLengths, int numPlanks)
        {
            //number of possiblities if k is greater than 0
            int p = (factorial(numPlanks + boardLengths.Length - 1)) / (factorial(numPlanks)*factorial(boardLengths.Length - 1));
            int count = p;
            //number of board sizes
            int nL = boardLengths.Length;
            //set to store the board combinations
            HashSet<int> boards = new HashSet<int>();

           /* while(count > 0)
            {
                //Calculate the possible lengths
                for (int i = 0; i <= numPlanks; i++)
                {
                    Console.WriteLine(s * i + l * j--);
                }
            }*/

            
            //(factorial(k+n-1))/((factorial(k)factorial(n-1)) = number of possiblities
            return numPlanks > 0 ? p : 0;
        }

        public int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * factorial(n - 1);

        }
    }
}
