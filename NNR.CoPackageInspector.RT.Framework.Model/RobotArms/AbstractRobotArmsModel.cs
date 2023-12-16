using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.Liblary.Utility.Maybe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.RobotArms
{
    /// <summary>
    /// ロボットアームの抽象化クラス
    /// </summary>
    public abstract class AbstractRobotArmsModel: IRobotArmsModel, IDisposable
    {
        protected SemaphoreSlim _readySemaphore = new SemaphoreSlim(1);
        protected event EventHandler _onAttachWorkpiece = delegate { };
        protected event EventHandler _onDettachWorkpiece = delegate { };
        protected IMaybe<IWorkpieceModel> _workpiece = Maybe.Empty<IWorkpieceModel>();

        #region プロパティ


        public SemaphoreSlim Owned => _readySemaphore;

        public IDisposable Disposable => this;

        #endregion


        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected AbstractRobotArmsModel()
        {
            _onAttachWorkpiece += OnCompleted;
            _onDettachWorkpiece += OnCompleted;
        }

        /// <summary>
        /// ワークを割り当てる
        /// </summary>
        /// <param name="workpiece"></param>
        public virtual void AttachWorkpiece(IWorkpieceModel workpiece)
        {
            _workpiece = Maybe.Create<IWorkpieceModel>(workpiece);
            _onAttachWorkpiece?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// ワークを解除する。
        /// </summary>
        /// <param name="workpiece"></param>
        public virtual void DettachWorkpiece(out IMaybe<IWorkpieceModel> workpiece)
        {
            workpiece = _workpiece;
            if (!_workpiece.HasObject) return;
            _workpiece = Maybe.Empty<IWorkpieceModel>();

            _onDettachWorkpiece?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// 完了処理
        /// </summary>
        protected virtual void OnCompleted(object sender, EventArgs e)
        {
            _readySemaphore.Release();
        }

        /// <summary>
        /// リソースの破棄
        /// </summary>
        public void Dispose()
        {
            _readySemaphore.Dispose();
            _onAttachWorkpiece -= OnCompleted;
            _onDettachWorkpiece -= OnCompleted;
        }
    }
}
