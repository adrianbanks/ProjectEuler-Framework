using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(37)]
    internal sealed class Problem37 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 2, 14);}}

        public override string Title
        {
            get
            {
                return "Find the sum of all eleven primes that are both truncatable from left to right and right to left.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.

Find the sum of the only eleven primes that are both truncatable from left to right and right to left.

NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
