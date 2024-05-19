
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.View.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider
{
    public class MenuPanelProvider
    {
        private List<UserControl> _menuPanels;

        public enum Menues
        {
            OverView,
            Main,
            AutoPilot,
        }
        public static MenuPanelProvider Create()
        {
            return new MenuPanelProvider();
        }
        private MenuPanelProvider()
        {
            _menuPanels = MainAppContextProvider.GetInstance().MainAppModel.MenuPanels;
        }

       public void SwitchToMenu(Menues menu)
        {
            foreach (var item in _menuPanels)
            {
                if ((menu == Menues.Main) && (item is IMainMenuPanel))
                {
                    item.Visible = true;
                }
                else if ((menu == Menues.AutoPilot) && (item is IAutoPilotMenu))
                {
                    item.Visible = true;
                }
                else if ((menu == Menues.OverView) && (item is IOverViewMenuPanel))
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
