using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class OddishEvenish
    {
        public string oddishOrEvenish(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum % 2 == 0 ? "Evenish" : "Oddish";
        }   
    }
}
