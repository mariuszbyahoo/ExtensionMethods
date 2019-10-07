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
    }
}
