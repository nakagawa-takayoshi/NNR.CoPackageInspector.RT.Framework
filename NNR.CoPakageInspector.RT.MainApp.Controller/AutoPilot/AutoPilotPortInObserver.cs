using NNR.CopackageInspector.RT.Framework.Controller.AutoPilot;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using NNR.CoPackageInspector.RT.Framework.Controller.Interface;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Controller.AutoPilot
{
    public class AutoPilotPortInObserver : AbstractAutoPilotPortInObserver
    {
        private StationCollection _stations;

        public AutoPilotPortInObserver(IAutoPilotObserver nextObserver) 
            : base(nextObserver)
        {
        }

    }
}
