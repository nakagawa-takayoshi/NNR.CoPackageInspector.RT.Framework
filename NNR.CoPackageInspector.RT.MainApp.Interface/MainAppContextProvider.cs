using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public class MainAppContextProvider
    {
        private static MainAppContextProvider _me = null;

        private IMainAppContext _mainAppContext;

        internal static MainAppContextProvider CreteInstance(IMainAppContext mainAppContext)
        {
            if (!(_me is null)) return _me;

            _me = new MainAppContextProvider(mainAppContext);

            return _me;
        }

        public static IMainAppContext GetInstance()
        {
            return _me._mainAppContext;
        }

        private MainAppContextProvider(IMainAppContext mainAppContext)
        {
            _mainAppContext = mainAppContext;
        }
    }
}
