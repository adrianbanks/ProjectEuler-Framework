using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(47)]
    internal sealed class Problem47 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 7, 4);}}

        public override string Title
        {
            get
            {
                return "Find the first four consecutive integers to have four distinct primes factors.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The first two consecutive numbers to have two distinct prime factors are:

14 = 2 x 7
15 = 3 x 5

The first three consecutive numbers to have three distinct prime factors are:

644 = 2² x 7 x 23
645 = 3 x 5 x 43
646 = 2 x 17 x 19.

Find the first four consecutive integers to have four distinct primes factors. What is the first of these numbers?";
            }
        }

        public override long? ExpectedAnswer{get {return 134043;}}
    }
}
