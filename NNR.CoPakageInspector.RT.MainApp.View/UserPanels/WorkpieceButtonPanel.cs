using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View.UserPanels
{
    /// <summary>
    /// ワークピースボタンパネル
    /// </summary>
    public partial class WorkpieceButtonPanel : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンのマウスオーバー
        /// </summary>
        private void _buttonInner_MouseHover(object sender, EventArgs e)
        {
            _workpiecePanel.BackColor = _buttonInner.FlatAppearance.MouseOverBackColor;
        }

        /// <summary>
        /// ボタンのマウスリーブ
        /// </summary>
        private void _buttonInner_MouseLeave(object sender, EventArgs e)
        {
            _workpiecePanel.BackColor = _buttonInner.BackColor;
        }

        /// <summary>
        /// ボタンのマウスダウン
        /// </summary>
        private void _buttonInner_MouseDown(object sender, MouseEventArgs e)
        {
            _workpiecePanel.BackColor = _buttonInner.FlatAppearance.MouseDownBackColor;
        }

        /// <summary>
        /// ボタンのマウスアップ
        /// </summary>
        private void _buttonInner_MouseUp(object sender, MouseEventArgs e)
        {
            _workpiecePanel.BackColor = _buttonInner.FlatAppearance.MouseOverBackColor;
        }
    }
}
