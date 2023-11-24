using NNR.CopackageInspector.RT.Framework.Model.AutoPilot;
using NNR.CoPackageInspector.RT.Framework.Controller.Interface;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace NNR.CopackageInspector.RT.Framework.Controller.AutoPilot
{
    public class AutoPilotObsavable
    {
        private List<IAutoPilotObserver> _observers;

        private List<Task<AutoPilotResult>> _tasks = new List<Task<AutoPilotResult>>();

        private EventHandler PreExecuteCompleted = delegate { };


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AutoPilotObsavable(List<IAutoPilotObserver> observers)
        {
            _observers = observers;

        }


        public IDisposable PreExecuteCompletedAsObservable(Action<EventArgs> action)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                        h => (s, e) => h(e),
                        h => PreExecuteCompleted += h,
                        h => PreExecuteCompleted -= h).Subscribe(action);
        }


        public void PreExecute()
        {
            _tasks.Clear();
            foreach (var observer in _observers)
            {
                var task = observer.PreExecute();
                _tasks.Add(task);
            }

            var waitForCompletedTask = Task.Run(() =>
            {
                Task.WaitAll(_tasks.ToArray());

                PreExecuteCompleted?.Invoke(this,EventArgs.Empty);

            });
        }


        public void Execute()
        {

        }


        /// <summary>
        /// リソースの破棄
        /// </summary>
        public void Dispose()
        {
            if (_observers is null) return;

            foreach(var observer in _observers)
            {
                observer.Dispose();
            }

            _observers.Clear();

            _observers = null;
        }


    }
}
