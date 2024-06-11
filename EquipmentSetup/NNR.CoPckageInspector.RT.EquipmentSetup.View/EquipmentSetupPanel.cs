using NNR.CoPackageInspector.RT.MainApp.Controller.PanelsProvider;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Windows.Forms;

namespace NNR.CoPckageInspector.RT.EquipmentSetup.View
{
    public partial class EquipmentSetupPanel : UserControl, IEqupmentSetupPanel
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public EquipmentSetupPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時のイベントハンドラ
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            //　装置設定メニューを表示します。
            var menuPanelProvider = MenuPanelProvider.Create();
            menuPanelProvider.SwitchMenu(NcopMenuType.Equipment);

            base.OnLoad(e);
        }

    }
}
