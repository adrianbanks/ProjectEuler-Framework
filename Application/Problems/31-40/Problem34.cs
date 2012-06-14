using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(34)]
    internal sealed class Problem34 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 1, 3);}}

        public override string Title
        {
            get
            {
                return "Find the sum of all numbers which are equal to the sum of the factorial of their digits.";
            }
        }

        public override string Description
        {
            get
            {
                return @"145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.

Find the sum of all numbers which are equal to the sum of the factorial of their digits.

Note: as 1! = 1 and 2! = 2 are not sums they are not included.";
            }
        }

        public override long? ExpectedAnswer{get {return 40730;}}
    }
}
