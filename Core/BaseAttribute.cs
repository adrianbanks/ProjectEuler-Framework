using System;

namespace ProjectEuler.Core
{
    public abstract class BaseAttribute : Attribute
    {
        public int Number{get {return number;}}
        private readonly int number;

        protected BaseAttribute(int number)
        {
            this.number = number;
        }
    }
}
