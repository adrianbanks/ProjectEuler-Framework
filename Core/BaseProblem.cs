using System;

namespace ProjectEuler.Core
{
    public abstract class BaseProblem : IComparable<BaseProblem>, IItemType
    {
        public int Number{get {return this.GetNumber<ProblemAttribute>();}}

        public abstract DateTime DateSet{get;}
        public abstract string Title{get;}
        public abstract string Description{get;}
        public virtual long? ExpectedAnswer{get {return null;}}

        public void Log(string text, params string[] args)
        {
            Logger.WriteLine(ConsoleColor.Green, text, args);
        }

        public int CompareTo(BaseProblem other)
        {
            return Number.CompareTo(other.Number);
        }
    }
}
