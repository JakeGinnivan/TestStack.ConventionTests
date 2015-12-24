namespace TestStack.ConventionTests.Reporting
{
    using TestStack.ConventionTests.Internal;
    using TestStack.ConventionTests.Logging;

    public class LibLogRendererRenderer : IResultsProcessor
    {
        static readonly ILog Logger = LogProvider.GetLogger("TestStack.ConventionTests");

        public void Process(IConventionFormatContext context, params ConventionResult[] results)
        {
            foreach (var conventionResult in results)
            {
                Logger.Info(context.TestResultProcessor.Process(context, conventionResult));
            }
        }
    }
}