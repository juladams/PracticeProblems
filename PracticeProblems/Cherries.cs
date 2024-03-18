using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Cherries
    {
        public int CherryPickup(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            //Create a 3D dp array
            int[,,] dp = new int[n, m, m];
            //Initialize the dp array with -1
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    for (int k = 0; k < m; k++)
                        dp[i, j, k] = -1;
            return Math.Max(0, dfs(grid, 0, 0, m - 1, dp));
        }

        //DFS(Recursive) approach to find the maximum cherries. grid, row, col1, col2, dp
        public int dfs(int[][] grid, int r, int c1, int c2, int[,,] dp)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            if (r == n)
                return 0;
            if (dp[r, c1, c2] != -1)
                return dp[r, c1, c2];
            int ans = 0;
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {
                    int nc1 = c1 + i;
                    int nc2 = c2 + j;
                    if (nc1 >= 0 && nc1 < m && nc2 >= 0 && nc2 < m)
                        ans = Math.Max(ans, dfs(grid, r + 1, nc1, nc2, dp));
                }
            int cherries = c1 == c2 ? grid[r][c1] : grid[r][c1] + grid[r][c2];
            return dp[r, c1, c2] = ans + cherries;
        }
    }
}
