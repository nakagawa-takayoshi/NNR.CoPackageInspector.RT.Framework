using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Model.AutoPilot.Enums
{
    public enum AutoPilotState
    {
        PreExecute = 0,
        PreEnter,
        CoreEnter,
        PostEnter,
        ContinetableEnter,
        PreExecuteComleted,
        Completed,
        Wait,
        Exit,
    }
}
