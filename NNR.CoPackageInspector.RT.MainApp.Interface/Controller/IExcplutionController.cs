using NNR.CoPackageInspector.RT.MainApp.Interface.Controller.ExclutionTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Controller
{
    public interface IExcplutionController
    {
        IAutoPilotTransition AutoPilotTransion { get; }
    }
}
