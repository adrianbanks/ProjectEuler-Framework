using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(14)]
    internal sealed class Problem14 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 4, 5);}}

        public override string Title
        {
            get
            {
                return "Find the longest sequence using a starting number under one million.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The following iterative sequence is defined for the set of positive integers:

n => n/2 (n is even)
n => 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:
13 => 40 => 20 => 10 => 5 => 16 => 8 => 4 => 2 => 1

It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.";
            }
        }

        public override long? ExpectedAnswer{get {return 837799;}}
    }
}
