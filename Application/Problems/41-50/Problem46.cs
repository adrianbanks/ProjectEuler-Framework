using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(46)]
    internal sealed class Problem46 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 6, 20);}}

        public override string Title
        {
            get
            {
                return "What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?";
            }
        }

        public override string Description
        {
            get
            {
                return @"It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

9 = 7 + 2 x 1^2
15 = 7 + 2 x 2^2
21 = 3 + 2 x 3^2
25 = 7 + 2 x 3^2
27 = 19 + 2 x 2^2
33 = 31 + 2 x 1^2

It turns out that the conjecture was false.

What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
