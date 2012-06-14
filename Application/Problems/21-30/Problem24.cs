using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(24)]
    internal sealed class Problem24 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 8, 16);}}

        public override string Title
        {
            get
            {
                return "What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?";
            }
        }

        public override string Description
        {
            get
            {
                return @"A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
