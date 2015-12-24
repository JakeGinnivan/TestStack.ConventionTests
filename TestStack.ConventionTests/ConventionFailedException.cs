namespace TestStack.ConventionTests
{
    using System;
#if !DOTNET
    using System.Runtime.Serialization;

    [Serializable]
#endif
    public class ConventionFailedException : Exception
    {
        public ConventionFailedException() { }
        public ConventionFailedException(string message) : base(message) { }
        public ConventionFailedException(string message, Exception inner) : base(message, inner) { }
#if !DOTNET
        protected ConventionFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
#endif
    }
}