using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(1)]
    internal sealed class Problem01 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2001, 10, 5);}}

        public override string Title
        {
            get
            {
                return "Add all the natural numbers below 1000 that are multiples of 3 or 5.";
            }
        }

        public override string Description
        {
            get
            {
                return @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.";
            }
        }

        public override long? ExpectedAnswer{get {return 233168;}}
    }
}
