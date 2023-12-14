using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.CoPakageInspector.RT.MainApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspectorApp
{
    public partial class MainAppForm : Form, IMainAppForm
    {
        private readonly SynchronizationContext _mainAppSyncchronizationConText;

        public SynchronizationContext MainAppSynchronizationContext => _mainAppSyncchronizationConText;

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

            var mainAppContext = MainAppContextProvider.GetInstance();
            var overViewPanel = new OverViewPanel();
            _mainSplitContainer.Panel1.Controls.Add(overViewPanel);
            overViewPanel.Visible = true;

            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(1280, 760);

            _mainSplitContainer.IsSplitterFixed = true;

            var mainAppModel = MainAppModelProvider.GetInstance();
            mainAppModel.AppCondition.State = ApplicationConditionState.Running;

        }

        /// <summary>
        /// フォームクローズのイベントハンドラ
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            var mainAppModel = MainAppModelProvider.GetInstance();
            mainAppModel.AppCondition.State = ApplicationConditionState.Exit;
            
            base.OnClosed(e);
        }
    }
}
