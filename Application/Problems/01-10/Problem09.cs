using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(9)]
    internal sealed class Problem09 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 1, 25);}}

        public override string Title
        {
            get
            {
                return "Find the only Pythagorean triplet, {a, b, c}, for which a + b + c = 1000.";
            }
        }

        public override string Description
        {
            get
            {
                return @"A Pythagorean triplet is a set of three natural numbers, a<b<c, for which,
a² + b² = c²

For example, 3² + 4² = 9 + 16 = 25 = 5².

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";
            }
        }

        public override long? ExpectedAnswer{get {return 31875000;}}
    }
}
