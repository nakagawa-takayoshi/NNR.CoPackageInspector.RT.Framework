using NNR.CoPackageInspector.RT.MainApp.Controller.ExculutionControllers.Triggers;
using NNR.CoPackageInspector.RT.MainApp.Interface.Controller;
using NNR.CoPackageInspector.RT.MainApp.Interface.Controller.ExclutionTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Controller
{
    internal class ExcluclutionController : IExcplutionController
    {
        public IAutoPilotTransition AutoPilotTransion { get; } = new AutoPilotTransition();

    }
}
