using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller.StateTransition
{
    /// <summary>
    /// Unscriber for trigger key
    /// </summary>
    public class TriggerKeyUnscriber: IDisposable
    {

        private IDisposable _disposable;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TriggerKeyUnscriber(ITriggerKey triggerKey, Action action)
        {
            _disposable = Disposable.Create(() => triggerKey.Triggered -= action);
        }

        /// <summary>
        /// 破棄
        /// </summary>
        public void Dispose()
        {
            _disposable.Dispose();
        }
    }
}
