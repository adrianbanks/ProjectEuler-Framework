using System;
using ProjectEuler.Core;

namespace ProjectEuler
{
    [Problem(79)]
    internal sealed class Problem79 : BaseProblem
    {
        public override DateTime DateSet{get {return new DateTime(2004, 9, 17);}}

        public override string Title
        {
            get
            {
                return "By analysing a user's login attempts, can you determine the secret numeric passcode?";
            }
        }

        public override string Description
        {
            get
            {
                return @"A common security method used for online banking is to ask the user for three random characters from a passcode. For example, if the passcode was 531278, they may ask for the 2nd, 3rd, and 5th characters; the expected reply would be: 317.

The text file, keylog.txt, contains fifty successful login attempts.

Given that the three characters are always asked for in order, analyse the file so as to determine the shortest possible secret passcode of unknown length.";
            }
        }

        public override long? ExpectedAnswer{get {return 73162890;}}
    }
}
