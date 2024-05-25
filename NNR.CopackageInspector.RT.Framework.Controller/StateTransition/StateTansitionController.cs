using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using NNR.CoPackageInspector.RT.Framework.Model.StateTansit;

namespace NNR.CopackageInspector.RT.Framework.Controller.StateTransition
{
    public  class StateTansitionController
    {

        TeriggerKeyCollection _triggerKeyCollection;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StateTansitionController(TeriggerKeyCollection teriggerKeyCollection)
        {
            _triggerKeyCollection = teriggerKeyCollection;
        }

        /// <summary>
        /// 状態遷移
        /// </summary>
        public void StateTansiton()
        {
            foreach (var triggerKey in _triggerKeyCollection.TriggerKeys)
            {
                if(triggerKey.TriggerHandle.WaitOne(0))
                {
                    triggerKey.OnTriggered();
                }
            }
        }

        IStateTransitionObsavable TriggerKeyAsObsavable(ITriggerKey triggerKey)
        {
            return new StateTransitionObsavable(triggerKey);
        }
    }
}
