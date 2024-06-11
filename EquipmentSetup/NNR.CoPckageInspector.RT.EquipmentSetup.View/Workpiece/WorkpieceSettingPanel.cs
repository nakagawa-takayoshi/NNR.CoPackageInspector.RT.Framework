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
                AddWorkpieceButtonPanel(new WorkpieceButtonPanel());
                AddWorkpieceButtonPanel(new WorkpieceButtonPanel());
                //AddWorkpieceButtonPanel(new WorkpieceButtonPanel());
            }

            var menuPanelProvider = MenuPanelProvider.Create();
            menuPanelProvider.SwitchMenu(NcopMenuType.WorkpieceSettings);

            base.OnLoad(e);
        }

        public void AddWorkpieceButtonPanel(WorkpieceButtonPanel workpieceButtonPanel)
        {
            _tableLayoutPanel.RowCount++;
            var rowStyle = new RowStyle(SizeType.AutoSize);
            _tableLayoutPanel.RowStyles.Add(rowStyle);
            _tableLayoutPanel.SetRow(workpieceButtonPanel, _tableLayoutPanel.RowCount);
            workpieceButtonPanel.Visible = true;
            _tableLayoutPanel.Controls.Add(workpieceButtonPanel);
            _tableLayoutPanel.Height = (workpieceButtonPanel.HeightWidthMargin * (_tableLayoutPanel.RowStyles.Count - 1));
        }

        public void RemoveWorkpieceButtonPanel(int index)
        {
            var control = _tableLayoutPanel.Controls[index];
            _tableLayoutPanel.Controls.Remove(control);

            _tableLayoutPanel.RowStyles.RemoveAt(index);

            _tableLayoutPanel.Height = (control.Height * _tableLayoutPanel.RowStyles.Count);
        }

        private void titleBar1_ReturnButtonClicked(object sender, EventArgs e)
        {
            var mainPanelsprovider = MainPanelsProvider.Create();
            mainPanelsprovider.SwitchPanel(NcopPanelType.Equuipment);
        }
    }
}
