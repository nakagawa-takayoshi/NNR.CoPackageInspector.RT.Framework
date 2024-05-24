using System;
using System.Drawing;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View.UserPanels
{
    public partial class ReadOnlyWorkpiecePanel : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ReadOnlyWorkpiecePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// クリックイベント
        /// </summary>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Parent is System.Windows.Forms.Button button)
            {
                button.PerformClick();
            }
        }

        /// <summary>
        /// マウスホバーのイベント
        /// </summary>
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            BackColor = SystemColors.ControlDark;
        }

        /// <summary>
        /// マウスリーブのイベント
        /// </summary>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = SystemColors.ButtonFace;
        }

        /// <summary>
        /// マウスダウンのイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            BackColor = SystemColors.ButtonFace;
        }

        /// <summary>
        /// マウスアップのイベント
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            BackColor = SystemColors.ControlDark;
        }
    }
}
