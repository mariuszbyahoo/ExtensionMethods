using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace ExtensionMethods.Library
{
    public static class ConfigurationExtensions
    {
        // Below a simple extension method, which checks are there any elements have been loaded into
        // The passed object implementing the IConfiguration interface
        public static bool IsLoaded(this IConfiguration config)
        {
            return config.AsEnumerable().Any();
        }

        public static IConfigurationBuilder AddStandardProviders(this IConfigurationBuilder configurationBuilder)
        {
            return configurationBuilder.AddJsonFile("appsettings.json")
                                        .AddEnvironmentVariables()
                                        .AddJsonFile("config/config.json", optional: true)
                                        .AddJsonFile("secrets/secrets.json", optional: true);
        }
    }
}
