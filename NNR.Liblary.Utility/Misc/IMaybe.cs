using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.Liblary.Utility.Misc
{
    public interface IMaybe<T>
    {
        bool HasObject { get; }

        T Object { get; }

        void Run(Action<T> action);
    }
}
