using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
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
    public partial class SubPanel : UserControl
    {
        public SubPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var mainAppModel = MainAppModelProvider.GetInstance();

            var mainMenu = new MainMenuPanel();
            mainMenu.Visible = false;
            mainAppModel.MenuPanels.Add(mainMenu);

            var autoPilotMenu = new AutoPilotMenuPanel();
            autoPilotMenu.Visible = false;
            mainAppModel.MenuPanels.Add(autoPilotMenu);

            SuspendLayout();

            var panel = tableLayoutPanel1.GetControlFromPosition(0, 0);
            tableLayoutPanel1.Controls.Remove(panel);

            tableLayoutPanel1.Controls.Add(mainMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(autoPilotMenu, 0, 0);

            var menuProvider = MenuPanelProvider.Create();
            menuProvider.SwitchToMenu(MenuPanelProvider.Menues.Main);

            ResumeLayout();

            base.OnLoad(e);
        }
    }
}
