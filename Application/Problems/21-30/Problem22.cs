using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(22)]
    internal sealed class Problem22 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2002, 7, 19);}}

        public override string Title
        {
            get
            {
                return "What is the total of all the name scores in the file of first names?";
            }
        }

        public override string Description
        {
            get
            {
                return @"Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938  53 = 49714.

What is the total of all the name scores in the file?";
            }
        }

        public override long? ExpectedAnswer{get {return 871198282;}}
    }
}
