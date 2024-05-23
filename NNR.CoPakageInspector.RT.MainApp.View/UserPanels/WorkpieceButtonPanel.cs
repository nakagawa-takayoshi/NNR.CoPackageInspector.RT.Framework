using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
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

        private event EventHandler ButtonClick;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel()
        {
            InitializeComponent();
        }

        public IObservable<EventArgs> ButtonClickedAsObservable()
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                               h => (sender, e) => h(e),
                                h => ButtonClick += h,
                                h => ButtonClick -= h
                   );
        }

        /// <summary>
        /// ボタンクリック処理
        /// </summary>
        private void _buttonInner_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender, e);
        }
    }
}
