using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model
{
    public class ApplicationCondition : IApplicationCondition, IDisposable
    {

        #region 内部メモリ

        private ApplicationConditionState _applicationConditionState = ApplicationConditionState.Startup;

        private CompositeDisposable _disposables = new CompositeDisposable();

        #endregion

        #region プロパティ

        /// <summary>
        /// コンディション状態のプロパティ
        /// </summary>
        public ApplicationConditionState State => _applicationConditionState;

        #endregion

        #region イベントハンドラ

        public event EventHandler<ApplicationConditionChangeEventArgs> ConditionChanged;

        #endregion


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ApplicationCondition()
        {
            _applicationConditionState = ApplicationConditionState.Startup;
        }


        #region イベントハンドラ

        /// <summary>
        /// コンディション切り替えハンドラ
        /// </summary>
        public void OnConditionChange(ApplicationConditionChangeEventArgs e)
        {
            _applicationConditionState = e.Condition;

            ConditionChanged?.Invoke(this, e);
        }

        #endregion


        #region メソッド


        public IDisposable ConditionChangeAsObservable(Action<ApplicationConditionChangeEventArgs> handler)
        {
            return Observable.FromEvent<EventHandler<ApplicationConditionChangeEventArgs>, ApplicationConditionChangeEventArgs>(
                    h => (s, e) => h(e),
                    h => ConditionChanged += h,
                    h => ConditionChanged -= h
                    ).Subscribe(handler);
        }

        /// <summary>
        /// オブジェクトの破棄
        /// </summary>
        public void Dispose()
        {
            _disposables?.Dispose();
        }

        #endregion
    }
}
