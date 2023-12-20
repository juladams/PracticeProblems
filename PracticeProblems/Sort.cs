using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    internal class Sort
    {
        public int[] mergeSort(int[]a1, int m, int[]a2, int n)
        {
            Queue<int> tmp = new Queue<int>();
            int j = 0;
            int i = 0;
            //a1 = {1,3,5,0,0,0} a2 = {2,4,6} tmp = maxInt
            //a1 = {1,2,5,0,0,0} a2 = {0,4,6} tmp = 3
            //a1 = {1,2,3,0,0,0} a2 = {0,4,6} tmp = 5
            
            while(j < n && i < n)
            {
                if (a2[j] > a1[i])
                    tmp.Enqueue(a1[i++]);
                else
                    tmp.Enqueue(a2[j++]);
            }
            if(i < n)
            {
                for(int k = i; k < m; k++)
                   tmp.Enqueue(a1[k]);
            }
            else if(j < n)
            {
                for(int k = j; k < n; k++)
                    tmp.Enqueue(a2[k]);
            }
            i = 0;
            while(tmp.Count > 0)
            {
                a1[i++] = tmp.Dequeue();
            }
            return a1;
        }
        public int[] mergeSort2(int[] a1, int m, int[] a2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = a1.Length - 1;

            while(i >= 0 && j >= 0)
            {
                if (a2[j] > a1[i])
                    a1[k--] = a2[j--];
                else
                    a1[k--] = a1[i--];
            }
            if (i >= 0)
            {
                for (int l = i; l >= 0; l--)
                    a1[k--] = a1[l];
            }
            else if (j >= 0)
            {
                for (int l = j; l >= 0; l--)
                    a1[k--] = a2[l];
            }
            return a1;
        }
    }   
}
