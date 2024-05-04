using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model.Event
{
    public class ApplicationConditionChangeEventArgs : EventArgs
    {
        private ApplicationConditionState _condition;

        public ApplicationConditionState Condition => _condition;

        public ApplicationConditionChangeEventArgs(ApplicationConditionState condition)
        {
            _condition = condition;
        }
    }
}
