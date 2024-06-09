using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Windows.Forms;

namespace NNR.CoPckageInspector.RT.EquipmentSetup.View.Workpiece
{
    public partial class WorkpieceSettingPanel : UserControl, IWorkpieceSettingPanel
    {     

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceSettingPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時のイベントハンドラ
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            if (!this.DesignMode)
            {
                _tableLayoutPanel.RowStyles.RemoveAt(0);
                _tableLayoutPanel.Height = 0;
            }

            base.OnLoad(e);
        }

        public void AddWorkpieceButtonPanel(WorkpieceButtonPanel workpieceButtonPanel)
        {
            var rowStyle = new RowStyle(SizeType.AutoSize);
            _tableLayoutPanel.RowStyles.Add(rowStyle);
            _tableLayoutPanel.SetRow(workpieceButtonPanel, _tableLayoutPanel.RowCount);
            _tableLayoutPanel.Height += workpieceButtonPanel.Height;
        }

        private void titleBar1_ReturnButtonClicked(object sender, EventArgs e)
        {
            var mainPanelsprovider = MainPanelsProvider.Create();
            mainPanelsprovider.SwitchPanel(NcopPanelType.Equuipment);
        }
    }
}
