using NNR.CoPakageInspector.RT.MainApp.Controller.PanelsProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class NavigationPanel : UserControl
    {
        public NavigationPanel()
        {
            InitializeComponent();
        }

        private void _buttonOverView_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchToPanel(MainPanelsProvider.Panel.OverView);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchToMenu(MenuPanelProvider.Menues.OverView);
        }

        private void _buttonEquipmentSetup_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchToPanel(MainPanelsProvider.Panel.Equuipment);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchToMenu(MenuPanelProvider.Menues.Main);
        }

        private void _buttonAutoPilot_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchToPanel(MainPanelsProvider.Panel.AutoPilot);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchToMenu(MenuPanelProvider.Menues.AutoPilot);
        }
    }
}
