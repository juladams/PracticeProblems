using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class PeekValley
    {
        public int[] setTerrain(int[] pk)
        {
            int[] tmp = new int[pk.Length];
            Array.Sort(pk);
            int j = 0;

            for (int i = 0; i < pk.Length/2; i++)
            {
                tmp[j++] = pk[i];
                tmp[j++] = pk[^(i+1)];
            }

            if (pk.Length % 2 == 1)
                tmp[^1] = pk[pk.Length / 2];

            return tmp;
        }
    }
}
