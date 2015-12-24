namespace TestStack.ConventionTests.Internal
{
    using System;
#if !DOTNET
    using System.Runtime.Serialization;

    [Serializable]
#endif
    public class NoDataFormatterFoundException : Exception
    {
        public NoDataFormatterFoundException()
        {
        }

        public NoDataFormatterFoundException(string message) : base(message)
        {
        }

        public NoDataFormatterFoundException(string message, Exception inner) : base(message, inner)
        {
        }

#if !DOTNET
        protected NoDataFormatterFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}