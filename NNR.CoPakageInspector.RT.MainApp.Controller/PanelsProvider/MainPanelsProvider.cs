using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.Controller.PanelsProvider
{
    public class MainPanelsProvider
    {
        private List<UserControl> _mainPanels;

        public enum Panel
        {
            OverView,
            AutoPilot,
            Equuipment,
        };

        public static MainPanelsProvider Create()
        {
            return new MainPanelsProvider();
        }

        private MainPanelsProvider()
        {
            var mainModel = MainAppContextProvider.GetInstance().MainAppModel;
            _mainPanels = mainModel.MainPanels;
        }


        public void SwitchToPanel(Panel panel)
        {
            foreach (var item in _mainPanels)
            {
                if ((panel == Panel.OverView) && (item is IOverViewPanel))
                {
                    item.Visible = true;
                }
                else if ((panel == Panel.AutoPilot) && (item is IAutoPilotPanel))
                {
                    item.Visible = true;
                }
                else if ((panel == Panel.Equuipment) && (item is IEqupmentSetupPanel))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }


    }
}
