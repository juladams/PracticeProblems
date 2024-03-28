using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Arrays
    {
        public List<int> DiagnolTraverse(int[][] mat)
        {
            int totalRows = mat.Length;
            int totalCols = mat[0].Length;
            List<int> res = new List<int>();
            bool up = true;

            int curRow = 0;
            int curCol = 0;
            
            while(res.Count < totalRows * totalCols)
            {
                //Up, to the right one and Up one
                if(up)
                {
                    while(curRow >= 0 && curCol < totalCols)
                    {
                        res.Add(mat[curRow][curCol]);
                        curRow--;
                        curCol++;
                    }
                    //out of bounds for row and col
                    if (curCol == totalCols)
                    {
                        curRow += 2;
                        curCol--;
                    }
                    //out of bounds for row
                    else
                        curRow++;

                    up = false;
                }
                //Down, to the left one and Down one
                else
                {
                    while(curCol >= 0 && curRow < totalRows)
                    {
                        res.Add(mat[curRow][curCol]);
                        curRow++;
                        curCol--;
                    }
                    //out of bounds for row and col
                    if(curRow == totalRows)
                    {
                        curRow--;
                        curCol += 2;
                    }
                    //out of bounds for col
                    else
                        curCol++;

                    up = true;

                }
            }

            return res;
        }

        public IList<int> SpiralOrder(int[][] matrix)
        {
            int total = matrix[0].Length * matrix.Length;

            int left = 0;
            int right = matrix[0].Length;
            int curCol = 0;

            int top = 0;
            int bottom = matrix.Length;
            int curRow = 0;

            string direction = "right";
            IList<int> res = new List<int>();

            while(res.Count < total)
            {
                if(direction == "right")
                {   
                    //Add the first row to the result
                    while(curCol < right)
                    {
                        res.Add(matrix[curRow][curCol]); 
                        curCol++;
                    }
                    //If the current column is equal to the total columns, decrement the current column and increment the current row
                    if(curCol == right)
                    {
                        curCol--;
                        top++;
                        curRow++;
                    }

                    direction = "down";
                }

                else if(direction == "down")
                {
                    //Add the last column to the result
                    while(curRow < bottom)
                    {
                        res.Add(matrix[curRow][curCol]); 
                        curRow++;
                    }
                    //If the current row is equal to the total rows, decrement the current row and decrement the current column
                    if(curRow == bottom)
                    {
                        curRow--;
                        curCol--;
                        right--;
                    }

                    direction = "left";
                }

                else if(direction == "left")
                {
                    //Add the last row to the result
                    while(curCol >= left)
                    {
                        res.Add(matrix[curRow][curCol]); 
                        curCol--;                        
                    }
                    //If the current column is less than or equal to the start column, increment the current column, decrement the current row
                    //and increment the start column
                    if(curCol <= left)
                    {
                        curCol++;
                        curRow--;
                        bottom--;
                    }

                    direction = "up";
                }

                else if(direction == "up")
                {
                    //Add the first column to the result
                    while(curRow >= top)
                    {
                        res.Add(matrix[curRow][curCol]); 
                        curRow--;                        
                    }
                    //If the current row is less than or equal to the start row, increment the current row, increment the start row
                    if(curRow <= top)
                    {
                        curRow++;
                        curCol++;
                        left++;

                    }

                    direction = "right";
                }
            }

            return res;
        }

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Dictionary<int, BigInteger> fact = new Dictionary<int, BigInteger>();
            fact.Add(0, 1);
            fact.Add(1, 1);

            foreach (int i in Enumerable.Range(0, numRows))
            {
                IList<int> tmp = new List<int>();
                //j is the number of elements in the current row
                //i is the current row, so we need to add i+1 elements because
                //the first row has 1 element and it is 0 indexed
                foreach (int j in Enumerable.Range(0, i+1))// 
                {
                    BigInteger val = Factorial(i, fact)/(Factorial(j, fact) * (Factorial(i - j, fact)));
                    
                    tmp.Add((int)val);
                }

                res.Add(tmp);
            }

            return res;
        }

        public BigInteger Factorial(int n, Dictionary<int, BigInteger> fact)
        {
            if(fact.ContainsKey(n))
                return fact[n];

            fact.Add(n, Factorial(n - 1, fact) * n);

            return fact[n];
        }
    }

}
