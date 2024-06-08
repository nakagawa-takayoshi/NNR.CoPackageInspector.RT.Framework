
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
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
        private IPanelsCollection<NcopMenuType> _menuPanels;

        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        public static MenuPanelProvider Create()
        {
            return new MenuPanelProvider();
        }
        private MenuPanelProvider()
        {
            _menuPanels = MainAppContextProvider.GetInstance().MainAppModel.MenuPanels;
        }

       public IDisposable SwitchMenu(NcopMenuType menuType)
        {
            return _menuPanels[menuType]();
        }
    }
}
