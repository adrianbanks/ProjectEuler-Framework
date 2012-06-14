using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(82)]
    internal class Problem82 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2004, 11, 5);}}

        public override string Title
        {
            get
            {
                return "Find the minimal path sum from the left column to the right column.";
            }
        }

        public override string Description
        {
            get
            {
                return @"NOTE: This problem is a more challenging version of Problem 81.

The minimal path sum in the 5 by 5 matrix below, by starting in any cell in the left column and finishing in any cell in the right column, and only moving up, down, and right, is indicated in red; the sum is equal to 994.

131	673	234	103	18
201	96	342	965	150
630	803	746	422	111
537	699	497	121	956
805	732	524	37	331

Find the minimal path sum, in matrix.txt (right click and 'Save Link/Target As...'), a 31K text file containing a 80 by 80 matrix, from the left column to the right column.";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
