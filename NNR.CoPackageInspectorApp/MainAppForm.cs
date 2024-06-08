using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.CoPackageInspector.RT.MainApp.Model.Collections;
using NNR.CoPackageInspector.RT.OverView.View;
using NNR.CoPakageInspector.RT.MainApp.View;
using NNR.CoPcakageInspector.RT.MainApp.Controller;
using NNR.CoPckageInspector.RT.EquipmentSetup.View;
using System;
using System.Drawing;
using System.Reactive.Disposables;
using System.Threading;
using System.Windows.Forms;

namespace NNR.CoPackageInspectorApp
{
    public partial class MainAppForm : Form, IMainAppForm
    {
        private readonly SynchronizationContext _mainAppSyncchronizationConText;
        private IDisposable _mainPanelDisposable = null;
        public SynchronizationContext MainAppSynchronizationContext => _mainAppSyncchronizationConText;

        public Control MainPanel => _navigationSplitContainer.Panel1;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainAppForm()
        {
            InitializeComponent();
            _mainAppSyncchronizationConText = SynchronizationContext.Current;
        }

        /// <summary>
        /// フォームロードのイベントハンドラ
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SuspendLayout();
            var mainAppContext = MainAppContextProvider.GetInstance();
            var mainAppModel = mainAppContext.MainAppModel;
            var writer = mainAppModel.GetWriter();

            //CreateMainPanels(MainPanel);

            ResumeLayout();

            var panelProvider = MainPanelsProvider.Create();
            _mainPanelDisposable = panelProvider.SwitchPanel(NcopPanelType.OverView);


            FormBorderStyle = FormBorderStyle.FixedDialog;
            Size = new Size(1280, 760);

            _mainSplitContainer.IsSplitterFixed = true;

            if (!base.DesignMode)
            {
                var applicationConditionController = ApplicationConditionController.Create(mainAppModel.AppCondition);
                applicationConditionController.Update(ApplicationConditionState.Running);
            }
        }

        /// <summary>
        /// フォームクローズのイベントハンドラ
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            var mainAppModel = MainAppModelProvider.GetInstance();
            var applicationConditionController = ApplicationConditionController.Create(mainAppModel.AppCondition);
            applicationConditionController.Update(ApplicationConditionState.Exit);

            base.OnClosed(e);
        }


        private IDisposable CreateOvewViewPanel(Control parentPanel)
        {
            _mainPanelDisposable?.Dispose();

            var panel = new OverViewPanel();
            parentPanel.Controls.Add(panel);

            panel.Visible = true;
            panel.Dock = DockStyle.Fill;

            return Disposable.Create(() =>
            {
                panel.Visible = false;
                parentPanel.Controls.Remove(panel);
                panel.Dispose();
            });
        }

        private IDisposable CreateEquipmentPanel(Control parentPanel)
        {
            _mainPanelDisposable?.Dispose();

            var panel = new EquipmentSetupPanel();
            parentPanel.Controls.Add(panel);

            panel.Visible = true;

            return Disposable.Create(() =>
            {
                panel.Visible = false;
                parentPanel.Controls.Remove(panel);
                panel.Dispose();
            });
        }

        private IDisposable CreateAutoPilotPanel(Control parentPanel)
        {
            _mainPanelDisposable?.Dispose();

            var panel = new AutoPilotPanel();
            parentPanel.Controls.Add(panel);

            panel.Visible = true;

            return Disposable.Create(() =>
            {
                panel.Visible = false;
                parentPanel.Controls.Remove(panel);
                panel.Dispose();
            });
        }

        public void CreateMainPanels(Control parentControl)
        {
            var mainAppContext = MainAppContextProvider.GetInstance();
            var mainAppModel = mainAppContext.MainAppModel;
            var mainPanels = mainAppModel.MainPanels;

            mainPanels.Add(NcopPanelType.OverView, () => { return _mainPanelDisposable = CreateOvewViewPanel(parentControl); });
            mainPanels.Add(NcopPanelType.Equuipment, () => { return _mainPanelDisposable = CreateEquipmentPanel(parentControl); });
            mainPanels.Add(NcopPanelType.AutoPilot, () => { return _mainPanelDisposable = CreateAutoPilotPanel(parentControl); });
        }
    }
}

