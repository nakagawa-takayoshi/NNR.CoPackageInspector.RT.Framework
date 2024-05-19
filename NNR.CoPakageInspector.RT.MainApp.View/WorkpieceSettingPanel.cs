using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.CoPakageInspector.RT.MainApp.View.UserPanels;
using System;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class WorkpieceSettingPanel : UserControl, IWorkpieceSettingPanel
    {     
        public WorkpieceSettingPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
    }
}
