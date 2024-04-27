using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NNR.Liblary.Utility.Misc
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

            public void Run(Action<T> action)
            {
                throw new InvalidOperationException(@"このオブジェクトは空オブジェクトです");
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

            public void Run(Action<T> action)
            {
                action(_object);
            }
        }


        /// <summary>
        /// 空オブジェクトを取得します。
        /// </summary>
        public static IMaybe<T> Empty<T>()
        {
            return new EmptyObject<T>();
        }

        /// <summary>
        /// Maybeオブジェクトの生成
        /// </summary>
        public static IMaybe<T> Create<T>(T obj)
        {
            return new Something<T>(obj);
        }
    }
}
