using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(41)]
    internal sealed class Problem41 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 4, 11);}}

        public override string Title
        {
            get
            {
                return "What is the largest n-digit pandigital prime that exists?";
            }
        }

        public override string Description
        {
            get
            {
                return @"We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.

What is the largest n-digit pandigital prime that exists?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
