namespace TestStack.ConventionTests.Conventions
{
    using System;
#if !DOTNET
    using System.Runtime.Serialization;

    [Serializable]
#endif
    public class ConventionSourceInvalidException : Exception
    {
        public ConventionSourceInvalidException() { }
        public ConventionSourceInvalidException(string message) : base(message) { }
        public ConventionSourceInvalidException(string message, Exception inner) : base(message, inner) { }
#if !DOTNET
        protected ConventionSourceInvalidException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context) { }
#endif
    }
}