using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Windows.Forms;

namespace NNR.CoPckageInspector.RT.EquipmentSetup.View
{
    public partial class EquipmentSetupPanel : UserControl, IEqupmentSetupPanel
    {
        public EquipmentSetupPanel()
        {
            InitializeComponent();
        }

        private void _buttonWorkSetup_Click(object sender, EventArgs e)
        {
            var panelProvider = MainPanelsProvider.Create();

        }
    }
}
