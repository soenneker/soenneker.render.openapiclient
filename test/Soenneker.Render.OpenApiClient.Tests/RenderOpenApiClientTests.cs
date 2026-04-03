using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Render.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class RenderOpenApiClientTests : FixturedUnitTest
{
    public RenderOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
