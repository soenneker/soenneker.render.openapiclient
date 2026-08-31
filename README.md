[![](https://img.shields.io/nuget/v/soenneker.render.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.render.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.render.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.render.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.render.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.render.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.render.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.render.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Render.OpenApiClient

Generated request builders and models for Render services, deploys, datastores, projects, environments, workflows, logs, metrics, and account resources.

## Installation

```bash
dotnet add package Soenneker.Render.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Render.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.render.com/v1"
};

var client = new RenderOpenApiClient(adapter);
var services = await client.Services.GetAsync(request =>
{
    request.QueryParameters.Limit = 3;
}, cancellationToken);
```

Render API keys use the bearer scheme. The anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries the `Authorization` header.

List operations are cursor-paginated. Read the cursor returned with a page and pass it through the next request's `Cursor` query parameter when more results are needed.
