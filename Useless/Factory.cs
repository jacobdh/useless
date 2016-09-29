namespace Useless
{
	using System;

	public class Factory<T>
	{
		public T Create()
		{

			return typeof(T).GetConstructor(Type.EmptyTypes) == null ? default(T) : (T)Activator.CreateInstance(typeof(T));
		}
	}
}
