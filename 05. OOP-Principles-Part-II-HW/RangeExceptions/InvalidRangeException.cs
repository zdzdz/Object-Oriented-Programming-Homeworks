using System;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        
        private const string ERROR_MESSAGE = "The value is out of range.";
        
        public InvalidRangeException(T start, T end)
            : base(ERROR_MESSAGE)
        {
            this.Start = start;
            this.End = end;
        }
        
        public T Start { get; private set; }
        public T End { get; private set; }
    }
}
