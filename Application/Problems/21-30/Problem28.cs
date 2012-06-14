using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(28)]
    internal sealed class Problem28 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 10, 11);}}

        public override string Title
        {
            get
            {
                return "What is the sum of both diagonals in a 1001 by 1001 spiral?";
            }
        }

        public override string Description
        {
            get
            {
                return @"Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13

It can be verified that the sum of the numbers on the diagonals is 101.

What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
