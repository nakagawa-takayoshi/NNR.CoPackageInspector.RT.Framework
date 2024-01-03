using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Controller.ExculutionControllers.Triggers
{
    public enum AutoPilotTriggerType
    {
        None = 0,
        ResetToOrigin = 1,
        AutoPilotOperation,
        NormalStop,
        EmergencyStop,
        End
    }
}
