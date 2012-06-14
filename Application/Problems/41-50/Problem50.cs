using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(50)]
    internal sealed class Problem50 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 8, 15);}}

        public override string Title
        {
            get
            {
                return "Which prime, below one-million, can be written as the sum of the most consecutive primes?";
            }
        }

        public override string Description
        {
            get
            {
                return @"The prime 41, can be written as the sum of six consecutive primes:

41 = 2 + 3 + 5 + 7 + 11 + 13

This is the longest sum of consecutive primes that adds to a prime below one-hundred.

The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.

Which prime, below one-million, can be written as the sum of the most consecutive primes?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
