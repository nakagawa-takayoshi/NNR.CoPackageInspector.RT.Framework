using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View.Menu;
using System;
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
            mainPanels.SwitchPanel(NcopPanelType.OverView);
        }

        private void _buttonEquipment_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchPanel(NcopPanelType.Equuipment);
        }

        private void _buttonAutoPilot_Click(object sender, EventArgs e)
        {
            var mainPanels = MainPanelsProvider.Create();
            mainPanels.SwitchPanel(NcopPanelType.AutoPilot);
        }
    }
}
