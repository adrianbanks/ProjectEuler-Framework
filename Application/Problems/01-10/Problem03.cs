using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(3)]
    internal sealed class Problem03 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2001, 11, 2);}}

        public override string Title
        {
            get
            {
                return "Find the largest prime factor of 317584931803.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 317584931803?";
            }
        }

        public override long? ExpectedAnswer{get {return 3919;}}
    }
}
