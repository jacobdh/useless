namespace Useless
{
	public class FactoryFactory<T>
	{
		public Factory<T> Create()
		{
			return new Factory<T>();
		}
	}
}
