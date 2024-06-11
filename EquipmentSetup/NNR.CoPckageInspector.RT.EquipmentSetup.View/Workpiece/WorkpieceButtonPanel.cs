using System;
using System.Reactive.Linq;
using System.Windows.Forms;
using NNR.CoPackageInspector.RT.Framework.Model.Workpiece;

namespace NNR.CoPckageInspector.RT.EquipmentSetup.View.Workpiece
{
    /// <summary>
    /// ワークボタンパネル
    /// </summary>
    public partial class WorkpieceButtonPanel : UserControl
    {
        private readonly WorkpieceTypeModel _workpieceTypeModel = null;
        private event EventHandler ButtonClick;
        private readonly Guid _guid;

        public int HeightWidthMargin => Size.Height + _buttonInner.Margin.Size.Height;

        public Guid Guid => _workpieceTypeModel.Uid;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel()
        {
            _guid = Guid.NewGuid();
            InitializeComponent();
            _workpiecePanel.Guid.Text = _guid.ToString();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceButtonPanel(WorkpieceTypeModel workpieceTypeModel)
            : this()
        {
            _workpieceTypeModel = workpieceTypeModel;
            _guid = workpieceTypeModel.Uid;
            _workpiecePanel.Guid.Text = workpieceTypeModel.Uid.ToString();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
        }

        /// <summary>
        /// ボタンクリックイベントの購読
        /// </summary>
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
