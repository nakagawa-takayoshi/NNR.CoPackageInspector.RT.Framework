using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model
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
        public ApplicationConditionState State
        {
            get => _applicationConditionState;
            set =>  OnConditionChange(new ApplicationConditionChangeEventArgs(value));
        }

        #endregion

        #region イベントハンドラ

        private event EventHandler<ApplicationConditionChangeEventArgs> ConditionChange;

        #endregion


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ApplicationCondition()
        {
            State = ApplicationConditionState.Startup;
        }


        #region イベントハンドラ

        /// <summary>
        /// コンディション切り替えハンドラ
        /// </summary>
        public void OnConditionChange(ApplicationConditionChangeEventArgs e)
        {
            _applicationConditionState = e.Condition;

            ConditionChange?.Invoke(this, e);
        }

        #endregion

        #region メソッド


        public IDisposable ConditionChangeAsObservable(Action<ApplicationConditionChangeEventArgs> handler)
        {
            return Observable.FromEvent<EventHandler<ApplicationConditionChangeEventArgs>, ApplicationConditionChangeEventArgs>(
                    h => (s, e) => h(e),
                    h => ConditionChange += h,
                    h => ConditionChange -= h
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
