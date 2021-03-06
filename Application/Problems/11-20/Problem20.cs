using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(20)]
    internal sealed class Problem20 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 6, 21);}}

        public override string Title
        {
            get
            {
                return "Find the sum of digits in 100!";
            }
        }

        public override string Description
        {
            get
            {
                return @"n! means n × (n − 1) × ... × 3 × 2 × 1

Find the sum of the digits in the number 100!";
            }
        }

        public override long? ExpectedAnswer{get {return 648;}}
    }
}
