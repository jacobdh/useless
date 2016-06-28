namespace Useless.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    [TestClass]
    public class NullFactoryTests
    {
        private NullFactory obj;

        [TestInitialize]
        public void Init()
        {
            this.obj = new NullFactory();
        }

        [TestMethod]
        public void Create_Should_Return_Null()
        {
            var result = this.obj.Create();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void CreateT_Should_Return_Null()
        {
            var result = this.obj.Create<ArgumentException>();

            Assert.IsNull(result);
        }
    }
}
