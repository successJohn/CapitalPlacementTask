using Microsoft.Azure.Cosmos;

namespace CapitalPlacementTask.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCosmos(this IServiceCollection services, IConfiguration configuration)
        {
            // Add CosmosClient and configure logging
            services.AddSingleton((provider) =>
            {
                var endpointUri = configuration["CosmosDbSettings:EndpointUri"];
                var primaryKey = configuration["CosmosDbSettings:PrimaryKey"];
                var databaseName = configuration["CosmosDbSettings:DatabaseName"];

                var cosmosClientOptions = new CosmosClientOptions
                {
                    ApplicationName = databaseName,
                    ConnectionMode = ConnectionMode.Direct,

                };

                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });

                var cosmosClient = new CosmosClient(endpointUri, primaryKey, cosmosClientOptions);


                return cosmosClient;
            });

        }
    }
}
