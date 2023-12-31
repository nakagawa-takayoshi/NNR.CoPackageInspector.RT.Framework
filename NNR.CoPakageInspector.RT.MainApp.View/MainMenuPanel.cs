using NNR.CoPackageInspector.RT.MainApp.Interface.View.Menu;
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
    public partial class MainMenuPanel : UserControl, IMainMenuPanel
    {
        public MainMenuPanel()
        {
            InitializeComponent();
        }

        private void _buttonOverView_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchToPanel(MainPanelsProvider.Panel.OverView);
        }

        private void _buttonEquipment_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchToPanel(MainPanelsProvider.Panel.Equuipment);
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
