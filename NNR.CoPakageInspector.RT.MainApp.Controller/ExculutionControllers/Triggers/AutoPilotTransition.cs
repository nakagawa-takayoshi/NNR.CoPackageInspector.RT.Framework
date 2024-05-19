using NNR.CoPackageInspector.RT.MainApp.Interface.Controller.ExclutionTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Controller.ExculutionControllers.Triggers
{
    public class AutoPilotTransition : IAutoPilotTransition
    {
        CompositeDisposable _resetToOrigin = new CompositeDisposable();

        public IDisposable ResetToOrigin
        {
            get
            {
                return _resetToOrigin;
            }
            set
            {
                _resetToOrigin.Add(value);
            }
        }

    }
}
