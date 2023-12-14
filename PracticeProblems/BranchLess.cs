using System;

namespace PracticeProblems
{
    internal class BranchLess
    {
        public double area(char shape, double meas)
        {
            return Convert.ToInt32(Char.ToLower(shape) == 'c') *(meas * 6.28) + Convert.ToInt32(Char.ToLower(shape) == 's')*(meas * 4);
        }
    }
}
