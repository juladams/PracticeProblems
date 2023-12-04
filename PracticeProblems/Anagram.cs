using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Anagram
    {
        public bool isAnagram(string s1,  string s2) 
        {
            s1 = s1.ToLower();
            if (s1.ToLower() == s2.ToLower()) return true;
            else if(s1.Length != s2.Length) return false;
            else
            {
                Dictionary<char, int> map = new Dictionary<char, int>();
                foreach (char c in s1.ToLower())
                {
                    if (map.ContainsKey(c))
                    {
                        map[c] = map[c]++;
                    }
                    else
                        map.Add(c, 1);
                }

                foreach (char c in s2.ToLower())
                {
                    if(!map.ContainsKey(c))
                        return false;
                }
            }
            return true;
        }
    }
}
