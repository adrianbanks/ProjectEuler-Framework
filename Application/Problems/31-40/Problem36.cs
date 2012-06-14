using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(36)]
    internal sealed class Problem36 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 1, 31);}}

        public override string Title
        {
            get
            {
                return "Find the sum of all numbers less than one million, which are palindromic in base 10 and base 2.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.

Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.

(Please note that the palindromic number, in either base, may not include leading zeros.)";
            }
        }

        public override long? ExpectedAnswer{get {return 872187;}}
    }
}
