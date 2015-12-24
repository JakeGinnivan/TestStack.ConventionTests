namespace TestStack.ConventionTests
{
    using System.Collections.Generic;
    using TestStack.ConventionTests.Reporting;

    public static class ConventionTestConfiguration
    {
        public static bool TraceReporterEnabled { get; set; } = true;
        public static bool ThrowOnFailureReporterEnabled { get; set; } = true;

        /// <summary>
        /// Add any additional reporters to this
        /// </summary>
        public static IList<IResultsProcessor> AdditionalReporters { get; } = new List<IResultsProcessor>();

        public static IList<IReportDataFormatter> Formatters { get; } = new List<IReportDataFormatter>
        {
            new TypeDataFormatter(),
            new ProjectReferenceFormatter(),
            new ProjectFileFormatter(),
            new MethodInfoDataFormatter(),
            new StringDataFormatter(),
            new ConvertibleFormatter(),
            new FallbackFormatter()
        };

        /// <summary>
        /// Result processors handle rendering the results
        /// </summary>
        public static IEnumerable<IResultsProcessor> ResultsProcessors
        {
            get
            {
                if (TraceReporterEnabled)
                    yield return new LibLogRendererRenderer();
                if (ThrowOnFailureReporterEnabled)
                    yield return new ThrowOnFailureResultsProcessor();

                foreach (var additionalReporter in AdditionalReporters)
                    yield return additionalReporter;
            }
        }

    }
}