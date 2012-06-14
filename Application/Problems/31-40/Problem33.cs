using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(33)]
    internal sealed class Problem33 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 12, 20);}}

        public override string Title
        {
            get
            {
                return "Discover all the fractions with an unorthodox cancelling method.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.

We shall consider fractions like, 30/50 = 3/5, to be trivial examples.

There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.

If the product of these four fractions is given in its lowest common terms, find the value of the denominator.";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
