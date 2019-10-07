using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ExtensionMethods.Tests
{
    [TestClass]
    public class ConfigurationExtensionsTests
    {
        [TestMethod]
        public void IsLoadedTest()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }

        [TestMethod]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }
    }
}
