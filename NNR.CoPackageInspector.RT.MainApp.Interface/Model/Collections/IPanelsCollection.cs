using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections
{
    public interface IPanelsCollection<T> where T : Enum
    {
        Func<IDisposable> this[T panelType] { get; }

        void Add(T panelType, Func<IDisposable> func);
    }
}
