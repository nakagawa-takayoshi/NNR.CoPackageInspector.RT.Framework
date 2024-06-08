using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Factory
{
    public interface IMenuPanelFactory
    {
        IDisposable Create(NcopPanelType panelType);
    }
}
