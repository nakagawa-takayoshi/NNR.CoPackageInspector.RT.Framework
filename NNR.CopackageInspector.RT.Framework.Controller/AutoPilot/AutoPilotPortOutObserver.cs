using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using NNR.CopackageInspector.RT.Framework.Model.AutoPilot.Enums;
using NNR.CoPackageInspector.RT.Framework.Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller.AutoPilot
{
    public class AutoPilotPortOutObserver : AbstractAutoPilotObserver, IAutoPilotObserver, IDisposable
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AutoPilotPortOutObserver() : base()
        {

        }


        /// <summary>
        /// リソースの破棄
        /// </summary>
        public void Dispose()
        {
            _disposables?.Dispose();
            _disposables = null;
        }


        protected override void PreExecute(AutoPilotResult autoPilotResult)
        {
            // ロボットアームを出力先に出力する。
            autoPilotResult.State = AutoPilotState.Completed;
        }

        protected override void PreEnter(AutoPilotResult autoPilotResult)
        {
            throw new NotImplementedException();
        }


        protected override void CoreEnter(AutoPilotResult autoPilotResult)
        {
            throw new NotImplementedException();
        }

        protected override void PostEnter(AutoPilotResult autoPilotResult)
        {
            throw new NotImplementedException();
        }

        protected override void ContinuetablEnter(AutoPilotResult autoPilotResult)
        {
            throw new NotImplementedException();
        }

        protected override void OnError(Exception e)
        {
            throw new NotImplementedException();
        }

        protected override void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
