using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model
{
    public interface IApplicationCondition
    {
        ApplicationConditionState State { get; }

        IDisposable ConditionChangeAsObservable(Action<ApplicationConditionState> action);

        Action<ApplicationConditionState> UpdateChange { get; }
    }
}
