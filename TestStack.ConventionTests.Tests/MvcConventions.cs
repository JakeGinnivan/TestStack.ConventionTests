#if NET45
namespace TestStack.ConventionTests.Tests
{
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using TestStack.ConventionTests.ConventionData;
    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class MvcConventions
    {
        [Fact]
        public void controller_conventions()
        {
            var types = Types.InAssemblyOf<TestController>();
            var convention = new MvcControllerNameAndBaseClassConvention();

            var ex = Assert.Throws<ConventionFailedException>(() => Convention.Is(convention, types));
            Approvals.Verify(ex.Message);
        }

        [Fact]
        public void api_controller_conventions()
        {
            var types = Types.InAssemblyOf<TestController>();
            var convention = new ApiControllerNamingAndBaseClassConvention();

            var ex = Assert.Throws<ConventionFailedException>(() => Convention.Is(convention, types));
            Approvals.Verify(ex.Message);
        }
    }
}
#endif