using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(32)]
    internal sealed class Problem32 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 12, 6);}}

        public override string Title
        {
            get
            {
                return "Find the sum of all numbers that can be written as pandigital products.";
            }
        }

        public override string Description
        {
            get
            {
                return @"We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.

The product 7254 is unusual, as the identity, 39 x 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.

Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.

HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
