using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Tests
{
    [TestClass()]
    public class TargetExtensionsTests
    {
        [TestMethod()]
        public void GetStandardizedIdTest()
        {
            var obj = new Target("id01");
            Assert.AreEqual("ID01", obj.GetStandardizedId());
            // The test above will fail because of the extension method's overriding.
        }
    }
}