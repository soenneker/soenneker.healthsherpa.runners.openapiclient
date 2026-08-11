using Soenneker.Tests.HostedUnit;

namespace Soenneker.HealthSherpa.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class HealthSherpaOpenApiClientRunnerTests : HostedUnitTest
{
    public HealthSherpaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
