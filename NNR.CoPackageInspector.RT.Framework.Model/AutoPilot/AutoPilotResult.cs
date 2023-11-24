using NNR.CopackageInspector.RT.Framework.Model.AutoPilot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Model.AutoPilot
{
    public class AutoPilotResult
    {
        public AutoPilotState State;
        public int result;

        public bool IsCompleted => (State == AutoPilotState.Completed);
    }
}
