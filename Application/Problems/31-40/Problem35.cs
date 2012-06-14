using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(35)]
    internal sealed class Problem35 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 1, 17);}}

        public override string Title
        {
            get
            {
                return "How many circular primes are there below one million?";
            }
        }

        public override string Description
        {
            get
            {
                return @"The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.

There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.

How many circular primes are there below one million?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
