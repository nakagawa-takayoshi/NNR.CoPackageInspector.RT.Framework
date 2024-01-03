using NNR.CoPackageInspector.RT.MainApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Controller.Factory
{
    public static class MainAppControllersFactory
    {
        public static IMainAppControllers Create()
        {
            return MainAppControllers.Create();
        }
    }
}
