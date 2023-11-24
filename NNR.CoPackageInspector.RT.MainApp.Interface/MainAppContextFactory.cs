using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public static class MainAppContextFactory
    {
        public static MainAppContextProvider Create(IMainAppContext appContext) 
        {
            return MainAppContextProvider.CreteInstance(appContext);
        }
    }
}
