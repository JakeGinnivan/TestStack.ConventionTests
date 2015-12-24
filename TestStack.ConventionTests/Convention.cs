namespace TestStack.ConventionTests
{
    using System.Collections.Generic;
    using TestStack.ConventionTests.ConventionData;
    using TestStack.ConventionTests.Internal;
    using TestStack.ConventionTests.Reporting;

    public static class Convention
    {

        public static void Is<TDataSource>(IConvention<TDataSource> convention, TDataSource data,
            ITestResultProcessor resultProcessor = null)
            where TDataSource : IConventionData
        {
            Execute(convention, data, ConventionTestConfiguration.ResultsProcessors, resultProcessor ?? new ConventionReportTextRenderer());
        }

#if !DOTNET
        /// <summary>
        /// Verifies a convention, any exceptions are written to ApprovalTests to approve
        /// </summary>
        /// <example>Convention.IsWithApprovedExeptions(new SomeConvention(), Types.InAssemblyOf&lt;SomeTypeOfMine&gt;())</example>
        public static void IsWithApprovedExeptions<TDataSource>(IConvention<TDataSource> convention, TDataSource data,
            ITestResultProcessor resultProcessor = null)
            where TDataSource : IConventionData
        {
            Execute(convention, data, ConventionTestConfiguration.ResultsProcessors, resultProcessor ?? new ConventionReportTextRenderer());
        }
#endif

        static void Execute<TDataSource>(IConvention<TDataSource> convention, TDataSource data,
            IEnumerable<IResultsProcessor> processors, ITestResultProcessor resultProcessor)
            where TDataSource : IConventionData
        {
            var dataDescription = string.Format("{0} in {1}", data.GetType().GetSentenceCaseName(), data.Description);
            var context = new ConventionContext(dataDescription, ConventionTestConfiguration.Formatters, processors, resultProcessor);
            context.Execute(convention, data);
        }
    }
}