using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller.AutoPilot
{
    public abstract class AbstractAutoPilotObserver
    {
        protected Queue<WorkpieceInspectResult> _workpieceResuletQueue = new Queue<WorkpieceInspectResult>();

        protected CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        protected Subject<AutoPilotResult> _subject = new Subject<AutoPilotResult>();

        protected CompositeDisposable _disposables = new CompositeDisposable();

        protected abstract void PreExecute(AutoPilotResult autoPilotResult);

        protected abstract void PreEnter(AutoPilotResult autoPilotResult);

        protected abstract void CoreEnter(AutoPilotResult autoPilotResult);

        protected abstract void PostEnter(AutoPilotResult autoPilotResult);

        protected abstract void ContinuetablEnter(AutoPilotResult autoPilotResult);

        protected abstract void OnError(Exception e);

        protected abstract void OnCompleted();


        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected AbstractAutoPilotObserver()
        {
            _workpieceResuletQueue.Clear();
            _disposables.Add(_subject.Where(x => (x.State == AutoPilotState.PreExecute)).Subscribe(PreExecute));
            _disposables.Add(_subject.Where(x => (x.State == AutoPilotState.PreEnter)).Subscribe(PreEnter));
            _disposables.Add(_subject.Where(x => (x.State == AutoPilotState.CoreEnter)).Subscribe(CoreEnter));
            _disposables.Add(_subject.Where(x => (x.State == AutoPilotState.PostEnter)).Subscribe(PostEnter));
            _disposables.Add(_subject.Where(x => (x.State == AutoPilotState.ContinetableEnter)).Subscribe(x => ContinuetablEnter(x),
                ex => OnError(ex),
                () => OnCompleted()));

        }

        /// <summary>
        /// 実行準備（回転中処理）
        /// </summary>
        public Task<AutoPilotResult> PreExecute()
        {
            var cancelToken = _cancellationTokenSource.Token;
            var task = Task<AutoPilotResult>.Run(() =>
            {
                var autoPilotResult = new AutoPilotResult() { State = AutoPilotState.PreExecute };

                try
                {
                    cancelToken.ThrowIfCancellationRequested();


                    while (autoPilotResult.State != AutoPilotState.PreExecuteComleted)
                    {
                        _subject.OnNext(autoPilotResult);
                        cancelToken.ThrowIfCancellationRequested();
                    }

                    _subject.OnCompleted();

                    return autoPilotResult;
                }
                catch (OperationCanceledException e)
                {
                    _subject.OnError(e);
                }

                return autoPilotResult;
            }, _cancellationTokenSource.Token);

            return task;
        }

        /// <summary>
        /// 実行処理（回転停止後）
        /// </summary>
        public Task<AutoPilotResult> Execute()
        {
            var task = Task<AutoPilotResult>.Run(() =>
            {
                var autoPilotResult = new AutoPilotResult() { State = AutoPilotState.CoreEnter };

                while (autoPilotResult.State != AutoPilotState.Completed)
                {
                    _subject.OnNext(autoPilotResult);
                }

                _subject.OnCompleted();

                return autoPilotResult;
            });

            return task;
        }

        /// <summary>
        /// ワークの検査結果をキューに追加する。
        /// </summary>
        public void PushBackWorkpieceResult(WorkpieceInspectResult workpieceInspectResult)
        {
            lock(_workpieceResuletQueue)
            {
                _workpieceResuletQueue.Enqueue(workpieceInspectResult);
            }
        }

        /// <summary>
        /// 現在のワークの検査結果の状態を取得します。
        /// </summary>
        /// <param name="autoPilotResult"></param>
        /// <returns></returns>
        protected AutoPilotState PeekNextStateFromWorkpieceQueue(AutoPilotResult autoPilotResult)
        {
            // キューが空であれば次のステートは完了にする。
            if (!(_workpieceResuletQueue.Any())) return AutoPilotState.Completed;

            return autoPilotResult.State;
        }

        
    }
}
