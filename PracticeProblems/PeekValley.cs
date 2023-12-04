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
            //Sort the array in ascending order
            Array.Sort(pk);
            //temp array index
            int j = 0;

            //iterate through the array alternating least to greatest int
            for (int i = 0; i < pk.Length/2; i++)
            {
                //inserting the least remaining int to next available pos
                tmp[j++] = pk[i];
                //inserting the greatest remaining int to next available pos
                tmp[j++] = pk[^(i+1)]; //from the end of the array
            }

            if (pk.Length % 2 == 1)
                tmp[^1] = pk[pk.Length / 2];

            return tmp;
        }
    }
}
