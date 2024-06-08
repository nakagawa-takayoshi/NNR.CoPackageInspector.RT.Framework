using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.View
{
    public interface IMainAppForm
    {
        SynchronizationContext MainAppSynchronizationContext { get; }

        Control MainPanel { get; }

        void CreateMainPanels(Control parentControl);

        void Close();
    }
}
