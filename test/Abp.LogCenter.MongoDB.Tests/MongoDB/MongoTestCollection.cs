using Xunit;

namespace Abp.LogCenter.MongoDB;

[CollectionDefinition(Name)]
public class MongoTestCollection : ICollectionFixture<MongoDbFixture>
{
    public const string Name = "MongoDB Collection";
}
