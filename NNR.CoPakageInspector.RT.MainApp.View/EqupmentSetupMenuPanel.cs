using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class EqupmentSetupMenuPanel : UserControl
    {
        public EqupmentSetupMenuPanel()
        {
            InitializeComponent();
        }

        private void _buttonWorkpieceSetting_Click(object sender, EventArgs e)
        {
            var mainPanelProvider = MainPanelsProvider.Create();
            mainPanelProvider.SwitchPanel(NcopPanelType.WorkpieceSetting);
        }
    }
}
