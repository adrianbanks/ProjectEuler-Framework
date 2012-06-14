using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(40)]
    internal sealed class Problem40 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 3, 28);}}

        public override string Title
        {
            get
            {
                return "Finding the nth digit of the fractional part of the irrational number.";
            }
        }

        public override string Description
        {
            get
            {
                return @"An irrational decimal fraction is created by concatenating the positive integers:

0.123456789101112131415161718192021...

It can be seen that the 12th digit of the fractional part is 1.

If dn represents the nth digit of the fractional part, find the value of the following expression.

d1 x d10 x d100 x d1000 x d10000 x d100000 x d1000000";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
