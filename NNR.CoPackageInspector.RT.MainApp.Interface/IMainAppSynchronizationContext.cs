using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public interface IMainAppSynchronizationContext
    {
        SynchronizationContext MainAppSynchronizationContext { get; }
    }
}
