using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class RandomizedSet
    {
        HashSet<int> set;

        public RandomizedSet()
        {
            this.set = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            if (set.Contains(val))
                return false;
            
            set.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (set.Contains(val))
            {
                set.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            Random rand = new Random();
            int index = rand.Next(0, set.Count);
            return set.ElementAt(index);
        }
    }
}
