using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(25)]
    internal sealed class Problem25 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 8, 30);}}

        public override string Title
        {
            get
            {
                return "What is the first term in the Fibonacci sequence to contain 1000 digits?";
            }
        }

        public override string Description
        {
            get
            {
                return @"The Fibonacci sequence is defined by the recurrence relation:
Fn = Fn-1 + Fn-2, where F1 = 1 and F2 = 1.

Hence the first 12 terms will be:
F1 = 1
F2 = 1
F3 = 2
F4 = 3
F5 = 5
F6 = 8
F7 = 13
F8 = 21
F9 = 34
F10 = 55
F11 = 89
F12 = 144

The 12th term, F12, is the first term to contain three digits.

What is the first term in the Fibonacci sequence to contain 1000 digits?";
            }
        }

        public override long? ExpectedAnswer{get {return 4782;}}
    }
}
