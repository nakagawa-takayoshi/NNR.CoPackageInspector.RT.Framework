using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using System;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider
{
    public class MainPanelsProvider
    {
        private IPanelsCollection<NcopPanelType> _panelSwitchModel;
    
        public static MainPanelsProvider Create()
        {
            return new MainPanelsProvider();
        }

        private MainPanelsProvider()
        {
            var mainModel = MainAppContextProvider.GetInstance().MainAppModel;
            _panelSwitchModel = mainModel.MainPanels;
        }


        public IDisposable SwitchPanel(NcopPanelType panelType)
        {
            return _panelSwitchModel[panelType]();
        }
    }
}
