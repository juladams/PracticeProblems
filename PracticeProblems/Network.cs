using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Network
    {
        //Dijkstra's algorithm
        public int NetworkDelayTime(int[][] times, int N, int K)
        {
            int[] dist = new int[N + 1];
            for (int i = 1; i <= N; i++)
                dist[i] = int.MaxValue;
            dist[K] = 0;

            for (int i = 0; i < N; i++)
            {
                
                foreach (int[] time in times)
                {
                    int u = time[0];
                    int v = time[1];
                    int w = time[2];
                    //if the distance to the node is not infinity and the distance to the next node is greater than the distance to the current node + the weight
                    if (dist[u] != int.MaxValue && dist[v] > dist[u] + w)
                        dist[v] = dist[u] + w;
                }
            }

            int res = dist.Max();
            return res == int.MaxValue ? -1 : res;
        }
    }
}
