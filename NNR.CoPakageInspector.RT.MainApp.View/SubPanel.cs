using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Model.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class SubPanel : UserControl
    {
        IDisposable _currentMenuPanelDisposable = null;

        public SubPanel()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (base.DesignMode) return;

            var mainAppModel = MainAppModelProvider.GetInstance();

            var menuPanelCollection = mainAppModel.MenuPanels;
            var parentControl = tableLayoutPanel1;

            menuPanelCollection.Add(NcopMenuType.OverView, () => CreateOverviewMenuPanel(parentControl));
            menuPanelCollection.Add(NcopMenuType.Main, () => CreateMainMenuPanel(parentControl));
            menuPanelCollection.Add(NcopMenuType.AutoPilot, () => CreateAutoPilotMenuPanel(parentControl));
            menuPanelCollection.Add(NcopMenuType.Equipment, () => CreateEquipmentMenuPanel(parentControl));

            SuspendLayout();

            var menuProvider = MenuPanelProvider.Create();
            _currentMenuPanelDisposable = menuProvider.SwitchMenu(NcopMenuType.OverView);

            ResumeLayout();

            base.OnLoad(e);
        }


        private IDisposable CreateOverviewMenuPanel(Control parentControl)
        {
            _currentMenuPanelDisposable?.Dispose();

            var overViewMenuPanel = new OverViewMenuPanel();
            overViewMenuPanel.Visible = true;
            parentControl.Controls.Add(overViewMenuPanel);
            return _currentMenuPanelDisposable = Disposable.Create(() =>
            {
                overViewMenuPanel.Visible = false;
                parentControl.Controls.Remove(overViewMenuPanel);
                overViewMenuPanel.Dispose();
            });
        }

        private IDisposable CreateMainMenuPanel(Control parentControl)
        {
            _currentMenuPanelDisposable?.Dispose();

            var mainMenuPanel = new MainMenuPanel();
            mainMenuPanel.Visible = true;
            parentControl.Controls.Add(mainMenuPanel);
            return _currentMenuPanelDisposable = Disposable.Create(() =>
            {
                mainMenuPanel.Visible = false;
                parentControl.Controls.Remove(mainMenuPanel);
                mainMenuPanel.Dispose();
            });
        }

        private IDisposable CreateAutoPilotMenuPanel(Control parentControl)
        {
            _currentMenuPanelDisposable?.Dispose();

            var autoPilotMenuPanel = new AutoPilotMenuPanel();
            autoPilotMenuPanel.Visible = true;
            parentControl.Controls.Add(autoPilotMenuPanel);
            return _currentMenuPanelDisposable = Disposable.Create(() =>
            {
                autoPilotMenuPanel.Visible = false;
                parentControl.Controls.Remove(autoPilotMenuPanel);
                autoPilotMenuPanel.Dispose();
            });
        }

        private IDisposable CreateEquipmentMenuPanel(Control parentControl)
        {
            _currentMenuPanelDisposable?.Dispose();

            var equipmentMenuPanel = new EqupmentSetupMenuPanel();
            equipmentMenuPanel.Visible = true;
            parentControl.Controls.Add(equipmentMenuPanel);
            return _currentMenuPanelDisposable = Disposable.Create(() =>
            {
                equipmentMenuPanel.Visible = false;
                parentControl.Controls.Remove(equipmentMenuPanel);
                equipmentMenuPanel.Dispose();
            });
        }
    }
}
