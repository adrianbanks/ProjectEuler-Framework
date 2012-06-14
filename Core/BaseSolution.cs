namespace ProjectEuler.Core
{
    public abstract class BaseSolution : IItemType
    {
        protected const long NOT_YET_SOLVED = 0;

        public int Number{get {return this.GetNumber<SolutionAttribute>();}}
        
        public abstract long GetAnswer();
    }
}
