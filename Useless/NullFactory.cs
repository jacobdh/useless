using System;

namespace Useless
{
    public class NullFactory
    {
	    public object Create()
	    {
		    return null;
	    }

        public T Create<T>()
            where T : class
        {
            return null;
        }
    }
}
