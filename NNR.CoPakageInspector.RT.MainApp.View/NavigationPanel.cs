using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
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
            mainPanels.SwitchPanel(NcopPanelType.OverView);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchMenu(NcopMenuType.OverView);
        }

        private void _buttonEquipmentSetup_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchPanel(NcopPanelType.Equuipment);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchMenu(NcopMenuType.Equipment);
        }

        private void _buttonAutoPilot_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchPanel(NcopPanelType.AutoPilot);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchMenu(NcopMenuType.AutoPilot);
        }
    }
}
