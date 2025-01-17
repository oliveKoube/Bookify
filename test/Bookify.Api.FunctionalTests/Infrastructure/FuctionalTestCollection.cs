namespace Bookify.Api.FunctionalTests.Infrastructure;

[CollectionDefinition(nameof(FuctionalTestCollection))]
public sealed class FuctionalTestCollection : ICollectionFixture<FunctionalTestWebAppFactory>;
