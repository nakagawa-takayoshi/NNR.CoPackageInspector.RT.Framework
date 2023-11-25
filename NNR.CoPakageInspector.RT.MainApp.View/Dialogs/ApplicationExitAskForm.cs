using NNR.CoPakageInspector.RT.MainApp.View.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View.Dialogs
{
    public partial class ApplicationExitAskForm : Form
    {
        private bool _isAllowApplicationExit;
        private CloseReason _closeReason = CloseReason.UserClosing;

        private static string[] _exitSelectComboText = new string[]
        { Resources.ExitMenuSleep, Resources.ExitMenuReboot, Resources.ExitMenuShutdown, Resources.ExitMenuApplicationExit, Resources.ExitMenuApplicationReboot, };

        private string[]  _exitSelectWithoutAppExitComboText = new string[]
        { Resources.ExitMenuSleep, Resources.ExitMenuReboot, Resources.ExitMenuShutdown, Resources.ExitMenuApplicationReboot, };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="isAllowApplicationExit"></param>
        public ApplicationExitAskForm(bool isAllowApplicationExit = true)
        {
            InitializeComponent();
            _isAllowApplicationExit = isAllowApplicationExit;
            var exitMenu  = isAllowApplicationExit ? _exitSelectComboText : _exitSelectWithoutAppExitComboText;
            _exitComboxBox.Items.AddRange(exitMenu);

        }

        /// <summary>
        /// フォームロード時のイベントハンドラ
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_closeReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            if (_isAllowApplicationExit)
            {
                _exitComboxBox.SelectedItem = Resources.ExitMenuApplicationExit;
            }
            else
            {
                _exitComboxBox.SelectedItem = Resources.ExitMenuShutdown;
            }

            base.OnShown(e);
        }

        /// <summary>
        /// ＯＫボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _closeReason = CloseReason.None;
            Close();
        }

        /// <summary>
        /// キャンセルボタン　クリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            _closeReason = CloseReason.None;
            Close();
        }
    }


}
