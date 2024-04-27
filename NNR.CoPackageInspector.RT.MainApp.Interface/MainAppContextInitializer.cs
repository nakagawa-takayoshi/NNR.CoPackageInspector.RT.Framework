using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public class MainAppContextInitializer
    {
        IMainAppContextWriter _mainAppContext;

        public IMainAppModel MainAppModel { set => _mainAppContext.MainAppModel = value; }

        public IMainAppControllers MainAppControllers { set => _mainAppContext.MainAppControllers = value; }

        public static MainAppContextInitializer Create(IMainAppContext mainAppContext)
        {
            return new MainAppContextInitializer(mainAppContext);
        }

        public MainAppContextInitializer(IMainAppContext mainAppContext) 
        {
            if (!(mainAppContext is IMainAppContextWriter writer)) throw new OperationCanceledException();

            _mainAppContext = writer;
        }


    }
}
