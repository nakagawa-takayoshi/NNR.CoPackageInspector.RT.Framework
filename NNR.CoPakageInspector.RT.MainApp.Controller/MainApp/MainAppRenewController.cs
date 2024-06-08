using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;

namespace NNR.CoPackageInspector.RT.MainApp.Controller.MainApp
{
    public class MainAppRenewController
    {
        IMainAppModelWriter _mainAppModelWriter;
        public MainAppRenewController(IMainAppModel mainAppModel)
        {
            _mainAppModelWriter = mainAppModel.GetWriter();
        }

    }
}
