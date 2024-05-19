using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Controller.ExculutionControllers
{
    public static class TransitionObserbavle
    {
        public static IDisposable AsOvservable(Control control)
        {
            control.Enabled = false;

            return Disposable.Create(() => { 
                control.Enabled = true;
            });
        }
    }
}
