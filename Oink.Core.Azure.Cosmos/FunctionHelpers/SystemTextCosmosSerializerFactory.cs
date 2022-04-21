using Microsoft.Azure.Cosmos;
using Microsoft.Azure.WebJobs.Extensions.CosmosDB;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Oink.Core.Azure.Cosmos.FunctionHelpers;
public class SystemTextCosmosSerializerFactory : ICosmosDBSerializerFactory
{
    public CosmosSerializer CreateSerializer()
    {
        var options = new JsonSerializerOptions
        {
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
        };

        return new SystemTextCosmosSerializer(options);
    }
}
