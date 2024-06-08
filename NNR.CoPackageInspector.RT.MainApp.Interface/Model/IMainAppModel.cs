using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Interface.Model
{
    public interface IMainAppModel
    {
        IStationCollection Stations { get; }

        IApplicationCondition AppCondition { get; }

        Control MainPanel { get; }

        IPanelsCollection<NcopPanelType> MainPanels { get; }

        IPanelsCollection<NcopMenuType> MenuPanels { get;}

        IMainAppModelWriter GetWriter();
    }
}
