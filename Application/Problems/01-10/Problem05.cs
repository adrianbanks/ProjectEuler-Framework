using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(5)]
    internal sealed class Problem05 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2001, 12, 14);}}

        public override string Title
        {
            get
            {
                return "What is the smallest number divisible by each of the numbers 1 to 20?";
            }
        }

        public override string Description
        {
            get
            {
                return @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest number that is evenly divisible (divisible with no remainder) by all of the numbers from 1 to 20?";
            }
        }

        public override long? ExpectedAnswer{get {return 232792560;}}
    }
}
