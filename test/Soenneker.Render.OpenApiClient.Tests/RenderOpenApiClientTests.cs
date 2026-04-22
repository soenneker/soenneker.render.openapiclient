using Soenneker.Tests.HostedUnit;

namespace Soenneker.Render.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RenderOpenApiClientTests : HostedUnitTest
{
    public RenderOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
