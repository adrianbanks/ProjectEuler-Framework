using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(48)]
    internal sealed class Problem48 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2003, 7, 18);}}

        public override string Title
        {
            get
            {
                return "Find the last ten digits of 1^1 + 2^2 + ... + 1000^1000.";
            }
        }

        public override string Description
        {
            get
            {
                return @"The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.

Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.";
            }
        }
        
        public override long? ExpectedAnswer{get {return 9110846700;}}
    }
}
