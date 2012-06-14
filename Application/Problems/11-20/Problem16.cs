using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(16)]
    internal sealed class Problem16 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 5, 3);}}

        public override string Title
        {
            get
            {
                return "What is the sum of the digits of the number 2^1000?";
            }
        }

        public override string Description
        {
            get
            {
                return @"2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?";
            }
        }

        public override long? ExpectedAnswer{get {return 1366;}}
    }
}
