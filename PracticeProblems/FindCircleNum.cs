using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FindCircleNum
    {
        public int findCircleNum(int[][] arr)
        {
            bool[] visited = new bool[arr.Length];
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (!visited[i])
                {
                    getFriends(arr, visited, i);
                    count++;
                }
            }

            return count;
        }

        //DFS approach to find all friends. getFriends(array, visited, row)
        public void getFriends(int[][] arr, bool[] visited, int i)
        {
            visited[i] = true;

            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[i][j] == 1 && !visited[j])
                        getFriends(arr, visited, j);
            }
        }
    }
}
