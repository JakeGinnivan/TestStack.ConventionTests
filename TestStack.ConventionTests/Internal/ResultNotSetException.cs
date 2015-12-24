namespace TestStack.ConventionTests.Internal
{
    using System;
#if !DOTNET
    using System.Runtime.Serialization;

    [Serializable]
#endif
    public class ResultNotSetException : Exception
    {
        public ResultNotSetException() { }
        public ResultNotSetException(string message) : base(message) { }
        public ResultNotSetException(string message, Exception inner) : base(message, inner) { }

#if !DOTNET
        protected ResultNotSetException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}