# 3.0.0 Breaking changes
 - ConventionReporterAttribute removed
    - Use Convention.Reports
 - `Convention.Formatters` moved to `ConventionTestConfiguration.Formatters`
 - Types.InAssemblyOf<T>(string descriptionOfTypes, Func<IEnumerable<Type>, IEnumerable<Type>> types) has been removed
 - ConventionReportTraceRenderer replaced by LibLogRenderer