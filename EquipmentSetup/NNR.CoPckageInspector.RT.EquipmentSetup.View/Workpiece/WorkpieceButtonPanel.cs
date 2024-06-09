using System;
using System.Reactive.Linq;
using System.Windows.Forms;
using NNR.CoPackageInspector.RT.Framework.Model.Workpiece;

namespace NNR.CoPckageInspector.RT.EquipmentSetup.View.Workpiece
{
    /// <summary>
    /// ワークピースボタンパネル
    /// </summary>
    public partial class WorkpieceButtonPanel : UserControl
    {
        private readonly WorkpieceTypeModel _workpieceTypeModel;
        private event EventHandler ButtonClick;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel(WorkpieceTypeModel workpieceTypeModel)
            : this()
        {
            _workpieceTypeModel = workpieceTypeModel;
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
