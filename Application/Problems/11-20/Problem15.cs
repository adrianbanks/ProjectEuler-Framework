using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(15)]
    internal sealed class Problem15 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 4, 19);}}

        public override string Title
        {
            get
            {
                return "Starting in the top left corner in a 20 by 20 grid, how many routes are there to the bottom right corner?";
            }
        }

        public override string Description
        {
            get
            {
                return @"Starting in the top left corner of a 2x2 grid, there are 6 routes (without backtracking) to the bottom right corner.

How many routes are there through a 20x20 grid?";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
