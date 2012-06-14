using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(7)]
    internal sealed class Problem07 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2001, 12, 28);}}

        public override string Title
        {
            get
            {
                return "Find the 10001st prime.";
            }
        }

        public override string Description
        {
            get
            {
                return @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10001st prime number?";
            }
        }

        public override long? ExpectedAnswer{get {return 104743;}}
    }
}
