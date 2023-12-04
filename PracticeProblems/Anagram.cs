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

            //If lengths do not match then they can't be anagrams
            else if(s1.Length != s2.Length) return false;
            else
            {
                //add chars to a dictionary with a count
                Dictionary<char, int> map = new Dictionary<char, int>();
                foreach (char c in s1.ToLower())
                {
                    if (map.ContainsKey(c))
                    {
                        map[c]++;
                    }
                    else
                        map.Add(c, 1);
                }

                //check if string1 and string2 have the same char occurance
                foreach (char c in s2.ToLower())
                {
                    if(map.ContainsKey(c))
                    {
                        if (map[c] > 1)
                            map[c]--;
                        else
                            map.Remove(c);
                    }
                    //char occurance doesn't exist
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
