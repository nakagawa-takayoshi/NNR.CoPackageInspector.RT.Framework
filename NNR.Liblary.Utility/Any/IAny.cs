using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.Liblary.Utility
{
    public interface IAny<T>
    {
        bool HasObject { get; }

        T Object { get; }
    }
}

