using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(81)]
    internal sealed class Problem81 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2004, 10, 22);}}

        public override string Title
        {
            get
            {
                return "Find the minimal path sum from the top left to the bottom right by moving right and down.";
            }
        }

        public override string Description
        {
            get
            {
                return @"In the 5 by 5 matrix below, the minimal path sum from the top left to the bottom right, by only moving to the right and down, is indicated in red and is equal to 2427.		

131	673	234	103	18
201	96	342	965	150
630	803	746	422	111
537	699	497	121	956
805	732	524	37	331

Find the minimal path sum, in matrix.txt (right click and 'Save Link/Target As...'), a 31K text file containing a 80 by 80 matrix, from the top left to the bottom right by only moving right and down.";
            }
        }

        public override long? ExpectedAnswer{get {return null;}}
    }
}
