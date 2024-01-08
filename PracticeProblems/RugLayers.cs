using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class RugLayers
    {
        public int rugLayers(string[] n)
        {
            int count = 0;
            int i = 0;
            HashSet<string> layers = new HashSet<string>();

            while (!layers.Contains(n[i]) && i > n.Length)
            {
                layers.Add(n[i++]);
                count++;
            }
            return count;
        }
    }
}
