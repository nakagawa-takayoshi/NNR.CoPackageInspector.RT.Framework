using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.Liblary.Utility.Maybe
{
    public class Maybe
    {
        private class EmptyObject<T> : IMaybe<T>
        {
            public bool HasObject => false;

            public T Object
            {
                get { throw new InvalidOperationException(@"このオブジェクトは空オブジェクトです"); }
            }

        }


        private class Something<T> : IMaybe<T>
        {
            private T _object;

            public Something(T obj)
            {
                _object = obj;
            }

            public bool HasObject => true;

            public T Object => _object;
        }


        /// <summary>
        /// 空オブジェクトを取得します。
        /// </summary>
        public static IMaybe<T> Empty<T>()
        {
            return new EmptyObject<T>();
        }

        public static IMaybe<T> Create<T>(T obj)
        {
            return new Something<T>(obj);
        }
    }
}
