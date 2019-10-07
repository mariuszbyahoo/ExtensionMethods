using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
