using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(4)]
    internal sealed class Problem04 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2001, 11, 16);}}

        public override string Title
        {
            get
            {
                return "Find the largest palindrome made from the product of two 3-digit numbers.";
            }
        }

        public override string Description
        {
            get
            {
                return @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.";
            }
        }

        public override long? ExpectedAnswer{get {return 906609;}}
    }
}
