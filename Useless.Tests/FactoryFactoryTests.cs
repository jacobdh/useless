namespace Useless.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System.Text;

	[TestClass]
	public class FactoryFactoryTests
	{
		[TestMethod]
		public void Create_Should_Create_Int_Factory()
		{
			var factoryFactory = new FactoryFactory<int>();
			var factory = factoryFactory.Create();
			var value = factory.Create();

			Assert.AreEqual(typeof(Factory<int>), factory.GetType());
			Assert.AreEqual(0, value);
		}

		[TestMethod]
		public void Create_Should_Create_NullFactory_Factory()
		{
			var nullFactoryFactoryFactory = new FactoryFactory<NullFactory>();
			var nullFactoryFactory = nullFactoryFactoryFactory.Create();
			var nullFactory = nullFactoryFactory.Create();

			Assert.AreEqual(typeof(NullFactory), nullFactory.GetType());
		}

		[TestMethod]
		public void Create_Should_Create_Different_Value_Objects()
		{
			var factoryFactory = new FactoryFactory<int>();
			var factory = factoryFactory.Create();

			var int1 = factory.Create();
			var int2 = factory.Create();

			Assert.IsFalse(ReferenceEquals(int1, int2));
		}

		[TestMethod]
		public void Create_Should_Create_Seperate_Factory_Instances()
		{
			var factoryFactory = new FactoryFactory<StringBuilder>();
			var factory1 = factoryFactory.Create();
			var factory2 = factoryFactory.Create();

			var stringBuilder1 = factory1.Create();
			var stringBuilder2 = factory1.Create();

			Assert.IsFalse(ReferenceEquals(factory1, factory2));
			Assert.IsFalse(ReferenceEquals(stringBuilder1, stringBuilder2));
		}
	}
}
