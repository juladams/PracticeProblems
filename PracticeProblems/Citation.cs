using System;

namespace PracticeProblems
{
    internal class Citation
    {
        public int HIndex(int[] citations)
        {
            if (citations.Length == 0)
                return 0;

            int h = citations.Length;
            Array.Sort(citations);
            for (int i = 0; i < h; i++)
            {
                if (citations[i] >= h - i)
                    return h - i;
            }
            return 0;
        }
    }
}