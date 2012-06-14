using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(17)]
    internal sealed class Problem17 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 5, 17);}}

        public override string Title
        {
            get
            {
                return "How many letters would be needed to write all the numbers in words from 1 to 1000?";
            }
        }

        public override string Description
        {
            get
            {
                return @"If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used? 


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of 'and' when writing out numbers is in compliance with British usage.";
            }
        }

        public override long? ExpectedAnswer{get {return 21124;}}
    }
}
