using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums
{
    public enum ApplicationConditionState
    {
        Startup = 0,
        HardwareInitialize,
        Running,
        Exit,
        End
    }
}
