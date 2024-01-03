using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public interface IMainAppContext
    {
        IMainAppForm MainAppForm { get; }

        IMainAppModel MainAppModel { get;}

        IMainAppControllers MainAppControlers { get; }
    }
}
