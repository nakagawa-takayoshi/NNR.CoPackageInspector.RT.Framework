using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.Liblary.Utility.Maybe
{
    public interface IMaybe<T>
    {
        bool HasObject { get; }

        T Object { get; }
    }
}
