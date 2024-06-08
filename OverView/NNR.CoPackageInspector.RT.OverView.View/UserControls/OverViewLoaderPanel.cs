using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.OverView.View.UserControls
{
    public partial class OverViewLoaderPanel : UserControl
    {
        private int _rowCount => _tableLayoutPanel.RowCount;

        #region プロパティ

        public int RowCount
        {
            get => _tableLayoutPanel.RowCount;
            set => _tableLayoutPanel.RowCount = value;
        }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OverViewLoaderPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時のイベント
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            _tableLayoutPanel.RowCount = 2;
            base.OnLoad(e);
        }

        public void Add(UserControl control)
        {
            _tableLayoutPanel.RowCount++;
            _tableLayoutPanel.SetRow(control, _rowCount);
        }

        public void Clear()
        {
           foreach (Control control in _tableLayoutPanel.Controls)
            {
                _tableLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
        }

    }
}
