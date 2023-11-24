using NNR.CopackageInspector.RT.Framework.Controller;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot.Enums;
using NNR.CoPackageInspector.RT.Framework.Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller.AutoPilot
{
    public class AutoPilotPortInObserver: AbstractAutoPilotObserver, IAutoPilotObserver, IDisposable
    {
        private IAutoPilotObserver _nextObserver;

        public AutoPilotPortInObserver(IAutoPilotObserver nextObserver) 
        {
            _nextObserver = nextObserver;

        }

        protected override void PreExecute(AutoPilotResult autoPilotResult)
        {
            Console.WriteLine(autoPilotResult.State.ToString());


            // 終了
            autoPilotResult.State = AutoPilotState.PreExecuteComleted;
        }

        protected override void PreEnter(AutoPilotResult autoPilotResult)
        {
            Console.WriteLine(autoPilotResult.State.ToString());

            // 処理するワークがあるか調べる
            autoPilotResult.State = PeekNextStateFromWorkpieceQueue(autoPilotResult);
            if (autoPilotResult.IsCompleted) return;


            var workpieceInspectResult = _workpieceResuletQueue.Peek();

            // ロボットアームを下す

            // 本処理へ
            autoPilotResult.State = AutoPilotState.CoreEnter;
        }


        protected override void CoreEnter(AutoPilotResult e)
        {
            Console.WriteLine(e.State.ToString());

            // ワークをロックする。
            // ロボットアームのワークを離す。

            e.State = AutoPilotState.PostEnter;
        }

        protected override void PostEnter(AutoPilotResult e)
        {
            Console.WriteLine(e.State.ToString());

            // ロボットアームを上げる。

            e.State = AutoPilotState.ContinetableEnter;

        }

        protected override void ContinuetablEnter(AutoPilotResult autoPilotResult)
        {
            autoPilotResult.State = PeekNextStateFromWorkpieceQueue(autoPilotResult);

            if (autoPilotResult.IsCompleted) return;

            if (!_workpieceResuletQueue.Any())
            {
                autoPilotResult.State = AutoPilotState.Completed;
                return;
            }

            var workpieceResult = _workpieceResuletQueue.Dequeue();
            _nextObserver.PushBackWorkpieceResult(workpieceResult);

            autoPilotResult.State = AutoPilotState.PreExecute;
        }


        /// <summary>
        /// エラー処理
        /// </summary>
        protected override void OnError(Exception e)
        {

        }


        /// <summary>
        /// 完了処理
        /// </summary>
        protected override void OnCompleted()
        {
            Console.WriteLine("Completed");
        }



        /// <summary>
        /// リソースの破棄
        /// </summary>
        public void Dispose()
        {
            _disposables?.Dispose();
            _disposables = null;
        }

    }
}
