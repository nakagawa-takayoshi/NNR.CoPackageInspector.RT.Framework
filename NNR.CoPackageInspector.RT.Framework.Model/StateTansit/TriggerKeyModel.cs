using NNR.CoPackageInspector.RT.Framework.Interface.Model.StateTansit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.StateTansit
{
    public class TriggerKeyModel
        : ITriggerKey
    {
        private AutoResetEvent _triggerKeyEvent = new AutoResetEvent(false);

        public EventWaitHandle TriggerHandle => _triggerKeyEvent;
        
        public event Action Triggered;

        public TriggerKeyModel()
        {
        }

        public void Trigger()
        {
            _triggerKeyEvent.Set();
        }

        public IDisposable TriggerdAsSubscribe(Action action)
        {
            Triggered += action;
            return Disposable.Create(() => Triggered -= action);
        }

        public void OnTriggered()
        {
            Triggered?.Invoke();
        }
    }
}
