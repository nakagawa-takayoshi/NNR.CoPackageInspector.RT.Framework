using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using NNR.CoPackageInspector.RT.Framework.Model.StateTansit;
using NNR.CoPackageInspector.RT.MainApp.Model.StateTransit.TriggerKeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller.StateTransition
{
    /// <summary>
    /// 状態遷移の監視コントローラー
    /// </summary>
    public class StateTransitionObsavable : IStateTransitionObsavable
    {

        private ITriggerKey _triggerKeyModel;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StateTransitionObsavable(ITriggerKey triggerKeyModel)
        {
            _triggerKeyModel = triggerKeyModel;
        }

        /// <summary>
        /// 購読
        /// </summary>
        public IDisposable Subscribe(Action action)
        {
            _triggerKeyModel.Triggered += action;
            return new TriggerKeyUnscriber(_triggerKeyModel, action);
        }
    }
}
