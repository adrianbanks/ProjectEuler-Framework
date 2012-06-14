using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(10)]
    internal sealed class Problem10 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 2, 8);}}

        public override string Title
        {
            get
            {
                return "Calculate the sum of all the primes below two million.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";
            }
        }

        public override long? ExpectedAnswer{get {return 142913828922;}}
    }
}
