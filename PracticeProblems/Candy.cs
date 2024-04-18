using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Candy
    {
        //There are N children standing in a line. Each child is assigned a rating value.
        //You are giving candies to these children subjected to the following requirements:
        //Each child must have at least one candy.
        public int candy(int[] ratings)
        {
            int[] candies = new int[ratings.Length];
            //initialize the candies array to 1
            for (int i = 0; i < candies.Length; i++)
                candies[i] = 1;
            
            //Start from the second element and work forwards
            for (int i = 1; i < ratings.Length; i++)
            {          
                if (ratings[i] > ratings[i - 1])
                   candies[i] = candies[i - 1] + 1;
            }
            
            //Start the second to last element and work backwards
            for (int i = candies.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    //if the current element is greater than the next element, and the current element's candy count is less than the next element's
                    //candy count + 1, then set the current element's candy count to the next element's candy count + 1
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }

            int totalCandies = candies.Sum();

            return totalCandies;
        }   
    }
}
