using System;
using System.Collections.Generic;
using System.Globalization;
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
        //Pascsal's Triangle
        public IList<IList<int>> Generate(int numRows)
        {
            //List to store the result
            IList<IList<int>> res = new List<IList<int>>();
            //Dictionary to store the factorial values
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
                    //Calculate the value of the current element using the formula for Pascal's Triangle
                    //nCr = n! / r!(n - r)! where n = i and r = j
                    BigInteger val = Factorial(i, fact)/(Factorial(j, fact) * (Factorial(i - j, fact)));
                    
                    tmp.Add((int)val);
                }

                res.Add(tmp);
            }

            return res;
        }

        //Pascal's Triangle Helper method
        public BigInteger Factorial(int n, Dictionary<int, BigInteger> fact)
        {
            if(fact.ContainsKey(n))
                return fact[n];

            fact.Add(n, Factorial(n - 1, fact) * n);

            return fact[n];
        }

        //Pascal's Triangle II
        public IList<int> GetRow(int rowIndex)
        {
            int n = rowIndex;
            //List to store the result
            IList<int> res = new List<int>();
            //Dictionary to store the factorial values
            Dictionary<int, BigInteger> fact = new Dictionary<int, BigInteger>();
            fact.Add(0, 1);
            fact.Add(1, 1);

            //i = current element in row. Total number of elements in the row is rowIndex+1
            foreach(int r in Enumerable.Range(0, n+1))
            {
                //Calculate the value of the current element using the formula for Pascal's Triangle
                //nCr = n! / r!(n - r)! 
                BigInteger val = Factorial(n, fact)/(Factorial(r, fact) * (Factorial(n - r, fact)));

                res.Add((int)val);
            }

            return res;   
        }

        //Add two binary numbers
        public string AddBinary(string a, string b)
        {
            if(a.Length < b.Length)
            {
                string tmp = a;
                a = b;
                b = tmp;
            }
            char[] aArr = a.ToCharArray();
            char[] bArr = b.ToCharArray();  
            bool carry = false;

            for(int i = 1; i <=b.Length; i++)
            {
                //if both are 1
                if (aArr[^i] == '1' && bArr[^i]  == '1')
                {
                    if (carry)
                        aArr[^i] = '1';
                    else
                    {
                        aArr[^i] = '0';
                        carry = true;
                    }
                }
                //if one is 1 and the other is 0
                else if ((aArr[^i] == '1' && bArr[^i] == '0') || (aArr[^i] == '0' && bArr[^i] == '1'))
                {
                    if(carry)
                       aArr[^i] = '0';
                    else
                        aArr[^i] = '1';
                }
                //if both are 0
                else
                {
                    if(carry)
                    {
                        aArr[^i] = '1';
                        carry = false;
                    }
                }
                //if we are at the first element and there is a carry
                if(i == b.Length && carry)
                {
                    for(int j = b.Length + 1; j <= a.Length; j++)
                    {
                        if (aArr[^j] == '1')
                        {
                            aArr[^j] = '0';
                        }
                        else
                        {
                            aArr[^j] = '1';
                            carry = false;
                            break;
                        }
                    }
                }
            }

            if(carry)
            {
                return "1" + new string(aArr);
            }

            return new string(aArr);
        }

        public string AddBinary2(string a, string b)
        {
            //Initialize the pointers to the end of the strings
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            StringBuilder sb = new StringBuilder();

            while( i >=0 || j >= 0)
            {
                //Add the two numbers and the carry. Subtract '0' to get the integer value of the character
                if(i >= 0)
                    carry += a[i--] - '0';
                if(j >= 0)
                    carry += b[j--] - '0';

                //Add the carry mod 2 to the string builder
                sb.Append(carry % 2);
                //Divide the carry by 2 to get the new carry
                carry /= 2;
            }

            if(carry > 0)
                sb.Append(carry);

            return new string(sb.ToString().Reverse().ToArray());
        }

        public int StrStr(string haystack, string needle) 
        {
            if(needle == null)
                return -1;

            //iterate through the chars to find the first match
            for(int i = 0; i < haystack.Length-needle.Length + 1; i++)
            {
                if(haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                {
                    int j = 0;
                    bool match = true;
                    
                    while(j < needle.Length && match == true)
                    {
                        if(haystack[i+j] != needle[j])
                        {
                            match = false;
                            break;
                        }
                        j++;
                    }

                    if(match)
                        return i;
                }
            }

            return -1;
        }

        public string LongestCommonPrefix(string[] strs) 
        {
            if(strs.Length == 1)
                return strs[0];

            int i = 0;
            bool pre = true;

            StringBuilder res = new StringBuilder();

            while(pre)
            { 
                char c;
                if(strs[0].Length <= i)
                    break;
                //    
                c = strs[0][i];

                for(int j = 0; j < strs.Length; j++)
                {
                    if(strs[j].Length == 0)
                        return "";

                    //Checking to see if 'i' is inbound of the length of the jth string of the array
                    if(strs[j].Length <= i)
                    {
                        pre = false;
                        break;
                    }
                    //CHecking if char equals char at position 'i' of string j
                    else if(!c.Equals(strs[j][i]))
                    {
                        pre = false;
                        break;
                    }
                }

                if(pre)
                {
                    res.Append(c);
                    i++;
                }
            }
            return res.Length == 0 ? "" : res.ToString();
        }
    
        //Rearange the array so that all the zeroes are at the end
        //The order of the non-zero elements should not change
        //example: [0,1,0,3,12] => [1,3,12,0,0]
        public void MoveZeroes(int[] nums)
        {
            int zPntr = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                    nums[zPntr++] = nums[i];            
            }
            for(int i = zPntr; i < nums.Length; i++)
                nums[i] = 0;
        }

        public string CustomSortString(string order, string s) 
        {
            if(s.Length == 1)
                return s;
            
            StringBuilder res = new StringBuilder();
            
            foreach(char c in order)
            {
                if(s.Contains(c))
                {
                    int count = s.Count(x => x == c);
                    res.Append(c, count);
                }
            }

            foreach(char c in s)
            {
                if(!order.Contains(c))
                    res.Append(c);
            }
            
            return res.ToString();
        }

        //Definition for singly-linked list.
        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) 
            {
                this.val = val;
                this.next = next;
            }
        }

        //LEET CODE 83, given a sorted linked list, delete all duplicates such that each element appears only once
        public ListNode DeleteDuplicates(ListNode head) 
        {
            if(head == null)
                return null;

            ListNode cur = head.next;
            ListNode prev = head;

            while(cur != null)
            {
                if(cur.val == prev.val)
                    cur = cur.next;

                else
                {
                    prev.next = cur;
                    prev = cur;
                    cur = cur.next;
                }
            }

            prev.next = null;

            return head;
            
        }
    }

}
