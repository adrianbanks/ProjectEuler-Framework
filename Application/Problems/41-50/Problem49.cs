using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(49)]
    internal sealed class Problem49 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 8, 1);}}

        public override string Title
        {
            get
            {
                return "Find arithmetic sequences, made of prime terms, whose four digits are permutations of each other.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.

There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.

What 12-digit number do you form by concatenating the three terms in this sequence?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
