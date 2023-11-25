using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.Liblary.Utility
{
    public class Any
    {
        public class EmptyObject<T> : IAny<T>
        {
            public bool HasObject => false;

            public T Object
            {
                get { throw new InvalidOperationException(@"このオブジェクトは空オブジェクトです"); }
            }



        }

        public class Something<T> : IAny<T>
        {
            private T _object;

            public Something(T obj)
            {
                _object = obj;
            }

            public bool HasObject => true;

            public T Object => _object;
        }

        public static IAny<T> Empty<T>()
        {
            return new EmptyObject<T>();
        }

        public static IAny<T> Create<T>(T obj)
        {
            return new Something<T>(obj);
        }

        public static IAny<T> FromValue<T>(T obj)
        {
            return new Something<T>(obj);
        }
    }
}

