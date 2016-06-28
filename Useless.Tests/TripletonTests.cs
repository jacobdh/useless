namespace Useless.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;

    [TestClass]
    public class TripletonTests
    {
        [TestMethod]
        public void Instance_Should_Return_3_Instances_At_Random()
        {
            var instances = Enumerable.Range(0, 100).Select(x => TestTripleton.Instance);
            var uniqueInstanceCount = instances.Distinct().Count();

            Assert.AreEqual(3, uniqueInstanceCount);
        }

        private class TestTripleton : Tripleton<TestTripleton>
        {
            private TestTripleton()
            {
            }
        }
    }
}
