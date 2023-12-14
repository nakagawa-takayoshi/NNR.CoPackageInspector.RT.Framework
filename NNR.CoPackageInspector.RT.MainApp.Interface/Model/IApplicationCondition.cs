using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model
{
    public interface IApplicationCondition
    {
        ApplicationConditionState State { get; set; }
    }
}
