namespace Useless
{
    using System;
    using System.Linq;

    public abstract class Tripleton<T>
        where T : class
    {
        private static readonly Lazy<T>[] instances;
        private static readonly Random random;

        static Tripleton()
        {
            instances = Enumerable.Range(0, 3).Select(x => new Lazy<T>(() => CreateInstance())).ToArray();
            random = new Random();
        }

        public static T Instance => instances[random.Next(0, instances.Length)].Value;

        private static T CreateInstance()
        {
            return Activator.CreateInstance(typeof(T), true) as T;
        }
    }
}
