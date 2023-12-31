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
    public partial class AutoPilotMenuPanel : UserControl, IAutoPilotMenu
    {
        public AutoPilotMenuPanel()
        {
            InitializeComponent();
        }


        ~AutoPilotMenuPanel()
        {
            var control = _titleBar.Controls[0];
            control.Click -= RootButton_Clicked;
        }

        protected override void OnLoad(EventArgs e)
        {
            var control = _titleBar.Controls[0];
            control.Click += RootButton_Clicked;
            base.OnLoad(e);
        }

        private void RootButton_Clicked(object sender, EventArgs e)
        {
            var menuPanel = MenuPanelProvider.Create();
            menuPanel.SwitchToMenu(MenuPanelProvider.Menues.Main);
        }
    }
}
