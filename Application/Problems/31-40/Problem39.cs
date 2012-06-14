using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(39)]
    internal sealed class Problem39 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 3, 14);}}

        public override string Title
        {
            get
            {
                return "If p is the perimeter of a right angle triangle, {a, b, c}, which value, for p <= 1000, has the most solutions?";
            }
        }

        public override string Description
        {
            get
            {
                return @"If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

{20,48,52}, {24,45,51}, {30,40,50}

For which value of p <= 1000, is the number of solutions maximised?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
